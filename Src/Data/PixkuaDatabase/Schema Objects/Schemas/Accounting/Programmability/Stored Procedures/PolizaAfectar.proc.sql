CREATE PROCEDURE [Accounting].[PolizaAfectar]
@IdPolizaTit AS VARCHAR(18)
AS
	SET NOCOUNT	ON
	SET xact_abort ON
		
	DECLARE @ErrorMessage nvarchar(4000),@Fecha as Datetime , @Hora as Datetime, @IdKardex as int,
			@IdEjercicioFiscalTit char(18),@IdPolizaDet int, @IdCuenta int, @Cargo decimal(18,4), @Abono decimal(18,4), @Monto decimal(18,4), @ExisteSaldoHist BIT,
			@IdEmpresa int	
	
	SELECT @Fecha=Documents.fxDocumentDate(@IdPolizaTit),@Hora=GetDate(),@IdKardex=0
	
	DECLARE cMovto CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT T.IdEjercicioFiscalTit,D.IdPolizaDet,D.IdCuenta,D.Cargo,D.Abono,(CASE WHEN  CS.IdCuentaSaldo IS NOT NULL THEN 1 ELSE 0 END)
		FROM Accounting.PolizasDet D
		INNER JOIN Accounting.PolizasTit T ON T.IdPolizaTit=D.IdPolizaTit AND T.Fecha=D.Fecha
		LEFT  JOIN Accounting.CuentasSaldos CS ON CS.IdCuenta=D.IdCuenta AND CS.IdEjercicioFiscalTit=T.IdEjercicioFiscalTit AND CS.Mes=Month(D.Fecha)
		WHERE D.IdPolizaTit=@IdPolizaTit AND D.Fecha=Documents.fxDocumentDate(@IdPolizaTit)
		ORDER BY D.Referencia,D.Orden
		
	OPEN cMovto
	FETCH NEXT FROM cMovto INTO @IdEjercicioFiscalTit, @IdPolizaDet, @IdCuenta, @Cargo, @Abono, @ExisteSaldoHist
	
	WHILE @@FETCH_STATUS=0
	BEGIN
		--Validamos un error en el que la cuenta lleve junto monto en cargo y abono 
		IF @Cargo<>0 AND @Abono <>0
		BEGIN
			SET @ErrorMessage = N'Existe un movimiento contable en la poliza["' + RTRIM(LTRIM(@IdPolizaTit)) + '] que acumulo cargo y abono simultaneo'
			RAISERROR (@ErrorMessage,18,1)
			Return
		END
		--Validamos q la poliza tenga en todos sus movimientos la cuenta. ( Al generar la poliza no necesariamente tiene la cuenta de todas las entidades)
		IF @IdCuenta=0
		BEGIN
			SET @ErrorMessage = N'Existe un movimiento contable en la poliza["' + RTRIM(LTRIM(@IdPolizaTit)) + '] que parece no haberse completado y provoco una referencia a la cuenta 0. Verifique que las entidades involucradas tengan una cuenta relacionada'
			RAISERROR (@ErrorMessage,18,1)
			Return
		END		
						
		--Guardamos en el kardex			
	    INSERT INTO Accounting.Kardex(IdPolizaTit,Fecha,IdPolizaDet,IdCuenta,Hora,CargoInicial,AbonoInicial,Cargo,Abono,CargoFinal,AbonoFinal)
			SELECT @IdPolizaTit,@Fecha, @IdPolizaDet,@IdCuenta,@Hora,C.Cargos,C.Abonos, @Cargo,@Abono,C.Cargos + @Cargo,C.Abonos+@Abono
			FROM Accounting.Cuentas AS C
			WHERE IdCuenta=@IdCuenta	
		
		SET @IdKardex=@@IDENTITY
		
		--Afectamos realmente la cuenta
		UPDATE 	Accounting.Cuentas SET Cargos=Q.CargoFin,Abonos=Q.AbonoFin,FechaUltMovto=@Hora
		FROM (	SELECT IdCuenta as IdCta,CargoFinal AS CargoFin,AbonoFinal AS AbonoFin
				FROM Accounting.Kardex 
				WHERE IdPolizaTit=@IdPolizaTit AND Fecha=@Fecha AND IdKardex=@IdKardex)Q
		WHERE IdCuenta=Q.IdCta
		
		--Actualizamos el Saldo de la cuenta en el periodo correspondiente
		IF @ExisteSaldoHist=1
			UPDATE Accounting.CuentasSaldos SET Cargos=Cargos+@Cargo,Abonos=@Abono
			WHERE IdEjercicioFiscalTit=@IdEjercicioFiscalTit AND IdCuenta=@IdCuenta and Mes>=month(@Fecha)
		ELSE
			INSERT Accounting.CuentasSaldos	(IdEjercicioFiscalTit,Mes,IdCuenta,Cargos,Abonos)
			VALUES(@IdEjercicioFiscalTit,MONTH(@Fecha),@IdCuenta,@Cargo,@Abono)
	
		FETCH NEXT FROM cMovto INTO @IdEjercicioFiscalTit,@IdPolizaDet, @IdCuenta, @Cargo, @Abono, @ExisteSaldoHist	
	END
	
	CLOSE cMovto
	DEALLOCATE cMovto


