CREATE PROCEDURE [Accounting].[CuentasImportarFile]
@IdEmpresa as int
AS

	DECLARE @LlaveNext int,@IdSucursal int,@CreateDate Datetime,@Nivel int
	DECLARE @Codigo Varchar(32),@Nombre Varchar(128),@IdCuentaTipo int,@Padre Varchar(32),@IdPadre int,@PathPadre varchar(512),@NamePathPadre varchar(1024),@SegNeg BIT

	SELECT @IdSucursal=IdSucursal,@CreateDate=GETDATE() FROM Sucursales WHERE IdEmpresa=@IdEmpresa
		
	DECLARE cMovto CURSOR FAST_FORWARD READ_ONLY FOR
		SELECT  Codigo,Nombre,IdCuentaTipo,Padre,IdPadre,IsNull(PathPadre,''),IsNull(NamedPath,'') ,SegNeg
		FROM(	SELECT CI.*,CT.IdCuentaTipo, C.Codigo AS CtaExistente,P.IdCuenta AS IdPadre,P.Path AS PathPadre,P.NamedPath
				FROM Accounting.CuentasImportacion CI
				LEFT JOIN Accounting.CuentasTipos CT ON CT.Abrev=CI.Tipo
				LEFT JOIN Accounting.Cuentas C ON C.Codigo=CI.Codigo AND C.IdEmpresa=@IdEmpresa
				LEFT JOIN Accounting.Cuentas P ON P.Codigo=CI.Padre  AND C.IdEmpresa=@IdEmpresa
		)C
		WHERE CtaExistente IS NULL
		ORDER BY Codigo

	--El siguiente consecutivo de llave de cuentas
	EXEC dbo.NewKey 'Accounting.Cuentas', @llaveNext out

	OPEN cMovto
	FETCH NEXT FROM cMovto INTO @Codigo,@Nombre,@IdCuentaTipo,@Padre,@IdPadre,@PathPadre,@NamePathPadre,@SegNeg
	WHILE @@FETCH_STATUS=0
	BEGIN
	
		IF @IdPadre IS NULL
		BEGIN
			SELECT @IdPadre=0
			SELECT @IdPadre=IsNull(IdCuenta,0),@PathPadre=IsNull(Path,''),@NamePathPadre=IsNull(NamedPath,'') FROM Accounting.Cuentas WHERE Codigo=@Padre 
		END

		SELECT @PathPadre		= IsNull(@PathPadre,'')     + CASE WHEN @IdPadre<>0 THEN '\'ELSE''END + CAST(@llaveNext as varchar(8))+'\' ,
			   @NamePathPadre	= IsNull(@NamePathPadre,'') + CASE WHEN @IdPadre<>0 THEN '\'ELSE''END + RTRIM(@Nombre) +'\' 
		
		SELECT @Nivel=dbo.fxCountCharacterIN('\',@PathPadre)
						
		INSERT INTO	Accounting.Cuentas (IdCuenta,IdPadre,Codigo,Nombre,IdCuentaTipo,Orden,Nivel,Path,NamedPath,IsLeaf,SegNeg,IdStatus,IdSucursal,IdEmpresa,CreateDate,LastUpdate,PCUpdate,Usercreate,UserUpdate)
		VALUES(@llaveNext,@IdPadre,@Codigo,@Nombre,@IdCuentaTipo,0,@Nivel,@PathPadre ,@NamePathPadre ,0,@SegNeg,1,@IdSucursal,@IdEmpresa,@CreateDate,@CreateDate,'Importacion',1,1 )
		
		SET @llaveNext=@llaveNext+1
		FETCH NEXT FROM cMovto INTO @Codigo,@Nombre,@IdCuentaTipo,@Padre,@IdPadre,@PathPadre,@NamePathPadre,@SegNeg
	END
	
	CLOSE cMovto
	DEALLOCATE cMovto	

	--actualizamos el siguiente consecutivo de llave de cuentas
	UPDATE Llaves SET Llave=@LlaveNext WHERE Tabla='Accounting.Cuentas'


