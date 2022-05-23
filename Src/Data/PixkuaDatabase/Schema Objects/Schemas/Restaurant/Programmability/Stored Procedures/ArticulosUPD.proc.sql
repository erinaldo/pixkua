-- =============================================
-- Author: alez Lopez
-- Create date: 19-ene-2011
-- Description:	Agrega o modifica la información de Articulos
-- =============================================
CREATE PROCEDURE [Restaurant].[ArticulosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@IdArticuloStock AS int,
	@IdCategoria AS int,
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
		EXEC dbo.NewKey 'Restaurant.Articulos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Restaurant.Articulos(IdArticulo, Codigo, IdArticuloStock, IdCategoria, Color, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @IdArticuloStock, @IdCategoria, @Color, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Restaurant.Articulos SET Codigo=@Codigo, IdArticuloStock=@IdArticuloStock, IdCategoria=@IdCategoria, Color=@Color, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdArticulo=@ID
		
	IF @Imagen IS NOT NULL 	
	   UPDATE Restaurant.Articulos SET Imagen=@Imagen WHERE IdArticulo=@ID


