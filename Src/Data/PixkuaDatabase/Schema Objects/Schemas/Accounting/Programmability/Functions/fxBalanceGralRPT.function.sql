CREATE FUNCTION [Accounting].[fxBalanceGralRPT](@IdEmpresa as int,@IdEjercicioFiscalTit AS char(18), @Mes AS int)
RETURNS @retTable TABLE (IdAgrupacion int, Agrupacion varchar(64),Definicion char(1),Cuenta varchar(128),Monto decimal(19,4),MontoMes decimal(19,4) )
BEGIN
	DECLARE @IdAgrupacion int, @Agrupacion Varchar(64),@Definicion char(1), @Nombre VarChar(64), @Path AS Varchar(512)
	
	--Balance General
	DECLARE cCuentas CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT A.IdCuentaTipoAgrupador,A.Descripcion,A.Definicion, C.Nombre,C.[Path]
		FROM Accounting.Cuentas C
		INNER JOIN Accounting.CuentasTipos T ON T.IdCuentaTipo=C.IdCuentaTipo
		INNER JOIN Accounting.CuentasTiposAgrupador A ON A.IdCuentaTipoAgrupador=T.IdCuentaTipoAgrupador
		WHERE	C.IdEmpresa=@IdEmpresa 
				AND T.IdCuentaTipoAgrupador IN (1,2,3) --Agrupacion
				AND C.IdCuentaOrden IN(1) --Cuentas de Mayor 
		
	OPEN cCuentas
	FETCH NEXT FROM cCuentas INTO @IdAgrupacion,@Agrupacion,@Definicion, @Nombre, @Path
	
	WHILE @@FETCH_STATUS=0
	BEGIN
		INSERT INTO @retTable
			SELECT @IdAgrupacion,@Agrupacion, @Definicion,@Nombre,
			IsNull(SUM(CS.Cargos+CS.Abonos),0) ,
			IsNull(SUM(CM.Cargos+CM.Abonos),0)						
			FROM Accounting.CuentasSaldos CS 
			INNER JOIN Accounting.Cuentas C ON C.IdCuenta=CS.IdCuenta
			LEFT  JOIN Accounting.CuentasSaldos CM ON CM.IdCuenta=C.IdCuenta AND CM.Mes=@Mes AND CM.IdEjercicioFiscalTit=CS.IdEjercicioFiscalTit
			--INNER JOIN Accounting.CuentasTiposAgrupador CTA ON CTA.IdCuentaTipoAgrupador=CT.IdCuentaTipoAgrupador
			WHERE CS.IdEjercicioFiscalTit=@IdEjercicioFiscalTit AND C.[Path] like @Path+'%'

		
		FETCH NEXT FROM cCuentas INTO @IdAgrupacion,@Agrupacion,@Definicion, @Nombre, @Path
	END
	CLOSE cCuentas
	DEALLOCATE cCuentas	
	
	DELETE @retTable WHERE Monto=0 OR Monto is null
	RETURN
END


