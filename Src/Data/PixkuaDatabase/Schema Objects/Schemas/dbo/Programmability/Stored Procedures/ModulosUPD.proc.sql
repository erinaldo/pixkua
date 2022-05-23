-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 31-Dic-2005
-- Description:	Agrega o modifica la información de Modulos
-- =============================================
CREATE PROCEDURE [dbo].[ModulosUPD]
	@Id AS int out,
	@Codigo AS varchar(10),
	@IdSucursal AS int,
	@IdParent AS int,
	@IdModuloCategoria as int,
	@Modulo AS varchar(32),
	@Orden AS int,
	@Descr AS varchar(256),
	@ImageFile as varchar(64),
	@IdStatus AS int,
	@IdEmpresa as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Modulos', @ID out

		IF @Codigo='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO dbo.Modulos(IdModulo, IdSucursal, IdParent, IdModuloCategoria, Modulo, Orden, Path, Descr, ImageFile,
			IdStatus, CreateDate, LastUpdate, PCUpdate, UserCreate, UserUpdate)
		VALUES (@Id, @IdSucursal, @IdParent, @IdModuloCategoria, @Modulo, @Orden,  '', @Descr, @ImageFile,
			@IdStatus, @LastUpdate, @LastUpdate, @PCUpdate, @UserUpdate, @UserUpdate)
	END
	ELSE
		UPDATE dbo.Modulos SET IdSucursal=@IdSucursal, IdParent=@IdParent, Modulo=@Modulo, Orden=@Orden, Path='', 
			Descr=@Descr, ImageFile=@ImageFile, IdModuloCategoria=@IdModuloCategoria,
			IdStatus=@IdStatus, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdModulo=@ID


