--Estado de Resultados
CREATE FUNCTION [Accounting].[fxEstadoResultadosRPT](@IdEmpresa as int,@IdEjercicioFiscalTit AS char(18), @Mes AS int)
RETURNS	@retTable TABLE(IdAgrupacion int, Agrupacion varchar(64),Cuenta varchar(128),MontoPeriodo decimal(19,4),MontoAcumulado decimal(19,4))
AS
BEGIN
	DECLARE @IdAgrupacion int, @Agrupacion Varchar(64), @Nombre VarChar(64), @Path AS Varchar(512),
			@FechaIniEjercicio datetime,@FechaFinEjercicio datetime,@FechaIniMes as Datetime,@FechaFinMes as datetime
	
	--Obtenemos la fecha de inicio y fin del mes 	
	SELECT @FechaIniEjercicio=FechaIni,@FechaFinEjercicio=FechaFin, @FechaIniMes= REPLACE( str(YEAR(FechaINI)) + (CASE WHEN @Mes<10THEN'0'ELSE''END)+STR(@Mes)+'01'  ,' ','')  FROM Accounting.EjerciciosFiscalesTit WHERE IdEjercicioFiscalTit=@IdEjercicioFiscalTit
	
	SET @FechaFinMes=DATEADD(M,1,@FechaIniMes)
	SET @FechaFinMes=DATEADD(D,-1,@FechaFinMes)	
	
			
	DECLARE cCuentas CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT T.IdCuentaTipoAgrupador,
			(CASE WHEN T.Naturaleza='A'THEN 'Ingresos' ELSE 'Egresos'END) AS Agrupador, --NATURALEZA
			C.Nombre,C.[Path]
		FROM Accounting.Cuentas C
		INNER JOIN Accounting.CuentasTipos T ON T.IdCuentaTipo=C.IdCuentaTipo
		WHERE C.IdEmpresa=@IdEmpresa AND C.IdCuentaOrden IN(1) --Cuentas de Mayor 1     --,Titulo 3, subtitulo 4
		AND T.IdCuentaTipoAgrupador IN (4)  --Cuentas de tipo RESULTADOS
		ORDER BY C.IdCuentaOrden
		
	OPEN cCuentas
	FETCH NEXT FROM cCuentas INTO @IdAgrupacion,@Agrupacion, @Nombre, @Path
	
	WHILE @@FETCH_STATUS=0
	BEGIN
	
		INSERT INTO @retTable
			SELECT @IdAgrupacion,@Agrupacion,@Nombre,IsNull(SUM(CM.Cargos+CM.Abonos),0),IsNULL(SUM(CS.Cargos+CS.Abonos),0)
			FROM Accounting.CuentasSaldos CS 
			INNER JOIN Accounting.Cuentas C ON C.IdCuenta=CS.IdCuenta
			LEFT  JOIN Accounting.CuentasSaldos CM ON CM.IdCuenta=C.IdCuenta AND CM.Mes=@Mes AND CM.IdEjercicioFiscalTit=CS.IdEjercicioFiscalTit
			--INNER JOIN Accounting.CuentasTiposAgrupador CTA ON CTA.IdCuentaTipoAgrupador=CT.IdCuentaTipoAgrupador
			WHERE CS.IdEjercicioFiscalTit=@IdEjercicioFiscalTit AND C.[Path] like @Path+'%'
			--GROUP BY CS.Mes--,CTA.Descripcion
		
		FETCH NEXT FROM cCuentas INTO @IdAgrupacion,@Agrupacion, @Nombre, @Path
	END
	CLOSE cCuentas
	DEALLOCATE cCuentas	
	
	--Insertamos la utilidad(o Perdida)
	INSERT INTO @retTable
		SELECT  1000,'Utilidad(o Perdida)','Utilidad(o Perdida)',SUM(ActivosMes-PasivosMes),SUM(Activos-Pasivos)
		FROM(
			SELECT	(CASE WHEN Definicion='A'THEN MontoMes ELSE 0 END) AS ActivosMes,
					(CASE WHEN Definicion='P'THEN MontoMes ELSE 0 END) AS PasivosMes,
					(CASE WHEN Definicion='A'THEN Monto    ELSE 0 END) AS Activos,
					(CASE WHEN Definicion='P'THEN Monto    ELSE 0 END) AS Pasivos
			FROM Accounting.fxBalanceGralRPT(@IdEmpresa,@IdEjercicioFiscalTit,@Mes)
		)Q

	DELETE @retTable WHERE MontoPeriodo=0 AND MontoAcumulado=0 
	
	RETURN
END


