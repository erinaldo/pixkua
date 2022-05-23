-- =============================================
-- Author: RCO
-- Create date: 14-oct-2010
-- Description:	Agrega o modifica la información de Articulos
-- =============================================
CREATE PROCEDURE [Sales].[ArticulosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(64),
	@IdUnidadMedida AS int,
	@IdMarca AS int,
	@Modelo AS varchar(64),
	@IdEstCom AS int,
	@IdCategoriaFlujo AS int,
	@IdStatus AS int,
	@IdEmpresa as int,
	@IdSucursal AS int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Sales.Articulos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Sales.Articulos(IdArticulo, Codigo, Nombre, IdUnidadMedida, IdMarca, Modelo, IdEstCom, IdCategoriaFlujo, 
			IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate, CreateDate, UserCreate)
		VALUES (@Id, @Codigo, @Nombre, @IdUnidadMedida, @IdMarca, @Modelo, @IdEstCom, @IdCategoriaFlujo, 
			@IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate, @LastUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Sales.Articulos SET Codigo=@Codigo, Nombre=@Nombre, IdUnidadMedida=@IdUnidadMedida, IdMarca=@IdMarca, 
			Modelo=@Modelo, IdEstCom=@IdEstCom, IdCategoriaFlujo=@IdCategoriaFlujo, 
			IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdArticulo=@ID


