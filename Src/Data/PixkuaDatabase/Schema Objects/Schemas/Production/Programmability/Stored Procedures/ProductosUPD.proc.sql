-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Agrega o modifica la información de Productos
-- =============================================
CREATE PROCEDURE [Production].[ProductosUPD]
	@Id AS int out,
	@Codigo AS varchar(32),
	@Nombre AS varchar(128),
	@IdArticuloStock AS int,
	@Cantidad AS decimal(18,4),
	@IdUnidadMedida AS int,
	@MultiploProduccion AS int,
	@EntregasParciales AS bit,
	@ExigirRecepcion AS bit,
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
		EXEC dbo.NewKey 'Production.Productos', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Production.Productos(IdProducto, Codigo, Nombre, IdArticuloStock, Cantidad, IdUnidadMedida, MultiploProduccion, EntregasParciales, ExigirRecepcion, IdCuenta, IdStatus, IdSucursal, IdEmpresa, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @IdArticuloStock, @Cantidad, @IdUnidadMedida, @MultiploProduccion, @EntregasParciales, @ExigirRecepcion, @IdCuenta, @IdStatus, @IdSucursal, @IdEmpresa, @LastUpdate, @PCUpdate, @UserUpdate)
		--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate
	END
	ELSE
		UPDATE Production.Productos SET Codigo=@Codigo, Nombre=@Nombre, IdArticuloStock=@IdArticuloStock, Cantidad=@Cantidad, IdUnidadMedida=@IdUnidadMedida, MultiploProduccion=@MultiploProduccion, EntregasParciales=@EntregasParciales, ExigirRecepcion=@ExigirRecepcion, IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdSucursal=@IdSucursal, IdEmpresa=@IdEmpresa, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdProducto=@ID


