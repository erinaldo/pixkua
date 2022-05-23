-- =============================================
-- Author: alex Lopez
-- Create date: 18-ene-2011
-- Description:	Agrega o modifica la información de Categorias
-- =============================================
CREATE PROCEDURE [Restaurant].[CategoriasUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@Imagen AS image=null,
	@Color AS varchar(32),
	@IdCuenta AS int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Restaurant.Categorias', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.Categorias(IdCategoria, Codigo, Nombre, Color, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @Color, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.Categorias SET Codigo=@Codigo, Nombre=@Nombre, Color=@Color, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdCategoria=@ID
		
		
	IF @Imagen IS NOT NULL 	
	   UPDATE Restaurant.Categorias SET Imagen=@Imagen WHERE IdCategoria=@ID


