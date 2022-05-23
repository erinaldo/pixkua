CREATE PROCEDURE [Accounting].[CuentasImportar](@IdEmpresa INT)
AS
	DECLARE @Formato VARCHAR(32),@Posicion int,@Cadena varchar(32),@Id int, @Segmento Varchar(16),@LlaveNext int,@FechaHoy as datetime,@Hoja as BIT
	DECLARE @CuentasTable TABLE(IdentityCuenta int IDENTITY(1,1), IdCuenta int, Codigo varchar(32),Nombre Varchar(128),IdCuentaTipo int,Importada BIT)
	DECLARE @SegmentoTable TABLE(Id int IDENTITY(1,1),Segmento varchar(16))
		
	SELECT @Formato = FormatoContable FROM Empresas WHERE IdEmpresa=@IdEmpresa

	IF LEN(@Formato)>0 
		SET @Formato=@Formato+'.'

	--Verificamos los segmentos de la empresa
	SELECT @Posicion=1,@Cadena='',@Segmento='',@FechaHoy=GETDATE()
	WHILE @Posicion<=LEN(@Formato)
	BEGIN
		IF SUBSTRING(@Formato,@Posicion,1) IN('-','.')
		BEGIN
			INSERT INTO @SegmentoTable VALUES (@Segmento)
			SELECT @Segmento=''
		END
		ELSE
			SELECT @Segmento=@Segmento+'0'
		
		SET @Posicion=@Posicion+1
	END
	
	SELECT @Posicion=MAX(Id)FROM @SegmentoTable

	--Cargamos las cuentas
	INSERT INTO @CuentasTable (IdCuenta,Codigo,Nombre,IdCuentatipo,Importada)
		SELECT 0,Q.Codigo,Q.Nombre,Q.IdCuentaTipo,0
		FROM(	SELECT DISTINCT CP.Codigo AS CtaPixcua, C.Codigo,C.Nombre,CT.IdCuentaTipo
				FROM Accounting.fxCuentasOrigenExterno(@IdEmpresa) C
				INNER JOIN Accounting.CuentasTipos CT ON CT.Abrev=C.Tipo
				LEFT JOIN Accounting.Cuentas CP ON CP.Codigo= C.Codigo COLLATE Modern_Spanish_CI_AS AND CP.IdEmpresa= @IdEmpresa
				WHERE substring(C.Codigo,1,1)<>'_'
		)Q WHERE Q.CtaPixcua is NULL
		ORDER BY Q.Codigo	

	--Le asigmanos la LLave del sistema
	EXEC dbo.NewKey 'Accounting.Cuentas', @llaveNext out
	UPDATE @CuentasTable SET IdCuenta = IdentityCuenta+@llaveNext
	SELECT @llaveNext=MAX(IdCuenta)+1 FROM @CuentasTable
	
	IF NOT @llaveNext IS NULL
		UPDATE LLaves SET  Llave=@llaveNext WHERE Tabla='Accounting.Cuentas'

	--Por cada segmento de negocio
	DECLARE cCuentas CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT Id,Segmento
		FROM @SegmentoTable	
		ORDER BY Id 
		
	OPEN cCuentas

	FETCH NEXT FROM cCuentas INTO @Id,@Segmento
	WHILE @@FETCH_STATUS=0
	BEGIN
		SELECT @Cadena='',@Hoja=0
		SELECT @Cadena=@Cadena+Segmento FROM @SegmentoTable WHERE Id>@ID
			
		IF @Posicion=@Id
			SET @Hoja=1
			
		--Obten e inserta las cuentas al nivel del segmento en turno.	
		INSERT INTO	Accounting.Cuentas (IdCuenta,IdPadre,Codigo,Nombre,IdCuentaTipo,Naturaleza,Orden,Nivel,Path,NamedPath,IsLeaf,IdStatus,IdSucursal,IdEmpresa,CreateDate,LastUpdate,PCUpdate,Usercreate,UserUpdate)
			SELECT C.IdCuenta,	IsNull(CP.IdCuenta,0)AS IdPadre,C.Codigo,C.Nombre,C.IdCuentaTipo,'',0,@Id,
								ltrim(rtrim(ISNULL(CP.[Path],''))) + ltrim(rtrim(STR(C.IdCuenta))) + '\', 
								ltrim(rtrim(IsNull(CP.NamedPath,''))) + ltrim(rtrim(C.Nombre)) + '\',
								@Hoja,1,0,@IdEmpresa,@FechaHoy,@FechaHoy,'Importacion',0,1
			FROM @CuentasTable C
			LEFT  JOIN Accounting.Cuentas CP ON CP.Codigo =  SUBSTRING(C.Codigo ,1 , len(C.Codigo)- len(@Segmento)-LEN(@Cadena) )  + @Segmento + @Cadena AND CP.IdEmpresa=@IdEmpresa
			WHERE C.Codigo like '%' + rtrim(ltrim(@Cadena)) AND C.Importada=0
		
		--marcamos las ya importadas
		UPDATE @CuentasTable SET Importada=1 WHERE Codigo like '%' + rtrim(ltrim(@Cadena)) AND Importada=0
		
		FETCH NEXT FROM cCuentas INTO @Id,@Segmento
	END

	CLOSE cCuentas
	DEALLOCATE cCuentas


