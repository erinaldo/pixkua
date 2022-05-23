-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 31-Dic-2005
-- Description:	Agrega o modifica la información de Procesos
-- =============================================
CREATE PROCEDURE [dbo].[ProcesosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdSucursal AS int,
	@IdEmpresa as int,
	@IdModulo AS int,
	@Proceso AS varchar(64),
	@Descr AS varchar(256),
	@IdProcesoTipo AS int,
	@Orden AS int,
	@ImageFile as varchar(64)='',
	@IdStatus AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Procesos', @ID out

		IF @Codigo='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Procesos(IdProceso, Codigo, IdSucursal, IdModulo, Proceso, Descr, IdProcesoTipo, Orden, ImageFile,
			IdStatus, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
		VALUES (@Id, @Codigo, @IdSucursal, @IdModulo, @Proceso, @Descr, @IdProcesoTipo, @Orden, @ImageFile,
			@IdStatus, @LastUpdate, @LastUpdate, @PCUpdate, @UserUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.Procesos SET Codigo=@Codigo, IdSucursal=@IdSucursal, IdModulo=@IdModulo, Proceso=@Proceso, Descr=@Descr, IdProcesoTipo=@IdProcesoTipo, 
			Orden=@Orden, ImageFile=@ImageFile,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdProceso=@ID


