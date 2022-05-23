CREATE PROCEDURE [dbo].[spRutasCuadroBasicoAdam]
AS
	DECLARE @tblCuadroBasico as TABLE (Ruta varchar(18),Vendedor int,Ayudante1 int,Ayudante2 int,Ayudante3 int,Ayudante4 int,Ayudante5 int)
	DECLARE @Ruta as varchar(18),@RutaAnt as varchar(18),@IdEmpleado as int,@Puesto as int,@Vendedor as int,@Ayudante1 as int,@Ayudante2 as int,@Ayudante3 as int,@Ayudante4 as int,@Ayudante5 as int
			
	SELECT @Vendedor=0,@Ayudante1=0,@Ayudante2=0,@Ayudante3=0,@Ayudante4=0,@Ayudante5=0

	DECLARE cCuadroBase CURSOR FAST_FORWARD READ_ONLY FOr
		SELECT Rel.Dato,E.IdEmpleado,Pto.Puesto--,Pto.descripcion
		FROM ADAM_AGA.dbo.Rel_Trab_Agr Rel
		INNER JOIN ADAM_AGA.dbo.Plazas P ON P.Trabajador=Rel.Trabajador 
		INNER JOIN ADAM_AGA.dbo.Puestos Pto on Pto.Puesto=P.Puesto
		left JOIN Attendance.RH.Empleados E ON E.Codigo = ltrim(rtrim(Rel.Trabajador)) COLLATE Modern_Spanish_CI_AI 
		--LEFT JOIN Distribution.Rutas R ON  CAST(ABS(dbo.CharToNumeric(R.Codigo)) as int) = CAST(ABS(dbo.CharToNumeric(Rel.Dato)) AS INT) AND R.IdRutaTipo not in (1,9)
		WHERE Rel.Agrupacion='RUTA_REP' AND abs(dbo.CharToNumeric(Rel.Dato)) >0 AND P.Puesto in(103,104,105) AND Rel.Dato like 'R%'
		Order By Rel.dato,P.Puesto
	  
	OPEN cCuadroBase
	FETCH NEXT FROM cCuadroBase INTO @Ruta,@IdEmpleado,@Puesto
	WHILE @@FETCH_STATUS=0
	BEGIN
		IF @Puesto = 104 OR @Puesto = 103 --Vendedores
			SET @Vendedor=@IdEmpleado
		
		IF @Puesto =  105 --Ayudantes
			IF @Ayudante1=0 
				SET @Ayudante1=@IdEmpleado
			ELSE IF @Ayudante2=0
				SET @Ayudante2=@IdEmpleado
			ELSE IF @Ayudante3=0
				SET @Ayudante3=@IdEmpleado
			ELSE IF @Ayudante4=0
				SET @Ayudante4=@IdEmpleado
			ELSE IF @Ayudante5=0
				SET @Ayudante5=@IdEmpleado

		SET @RutaAnt =@Ruta
	
		FETCH NEXT FROM cCuadroBase INTO @Ruta,@IdEmpleado,@Puesto

		IF @RutaAnt<>@Ruta
		BEGIN
			INSERT INTO @tblCuadroBasico Values(@RutaAnt,@Vendedor,@Ayudante1,@Ayudante2,@Ayudante3,@Ayudante4,@Ayudante5)
			SELECT @Vendedor=0,@Ayudante1=0,@Ayudante2=0,@Ayudante3=0,@Ayudante4=0,@Ayudante5=0
		END
	END	 

	CLOSE cCuadroBase
	DEALLOCATE cCuadroBase 

	UPDATE Distribution.Rutas SET IdEmpleado=IsNull(Vendedor,0),IdAyudante1=IsNull(Ayudante1,0),IdAyudante2=IsNull(Ayudante2,0),IdAyudante3=IsNull(Ayudante3,0),IdAyudante4=IsNull(Ayudante4,0),IdAyudante5=IsNull(Ayudante5,0)
 	FROM Distribution.Rutas R
	INNER JOIN @tblCuadroBasico CB ON  CAST(ABS(dbo.CharToNumeric(R.Codigo)) as int) = CAST(ABS(dbo.CharToNumeric(CB.Ruta)) AS INT) 
	WHERE R.IdRutaTipo not in (1,9,16)


