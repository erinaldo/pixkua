-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Agrega o modifica la información de ArticulosStock
-- =============================================
CREATE PROCEDURE [Inventory].[ArticulosStockUPD]
	@Id AS int out,
	@Codigo AS varchar(16),
	@Nombre AS varchar(64),
	@Descripcion AS varchar(256),
	@IdUnidadMedida AS int,
	@StockMax AS decimal(19,4),
	@StockMin AS decimal(19,4),
	@PuntoReorden AS decimal(19,4),
	@UltimoCosto AS decimal(19,4),
	@CostoPromedio AS decimal(19,4),
	@Orden AS int,
	@EAN AS varchar(32),
	@Origen AS char(1),
	@IdCuenta AS int,
	@IdStatus AS int,
	@IdSucursal AS int,
	@IdEmpresa as int,
	@LastUpdate AS datetime,
	@PCUpdate AS varchar(32),
	@UserUpdate AS int
AS
	SET NOCOUNT ON
	
	IF @ID=0
	BEGIN
		EXEC dbo.NewKey 'Inventory.ArticulosStock', @ID out

		IF LTrim(@Codigo)='' 
			SET @Codigo=LTrim(Str(@Id))
		
		INSERT INTO Inventory.ArticulosStock(IdArticuloStock, Codigo, Nombre, Descripcion, 
			IdUnidadMedida, StockMax, StockMin, PuntoReorden, UltimoCosto, CostoPromedio, 
			Orden, EAN, Origen, IdCuenta, IdStatus, IdEmpresa, IdSucursal, LastUpdate, PCUpdate, UserUpdate)
		VALUES (@Id, @Codigo, @Nombre, @Descripcion, 
			@IdUnidadMedida, @StockMax, @StockMin, @PuntoReorden, @UltimoCosto, @CostoPromedio, 
			@Orden, @EAN, @Origen, @IdCuenta, @IdStatus, @IdEmpresa, @IdSucursal, @LastUpdate, @PCUpdate, @UserUpdate)
	END
	ELSE
		UPDATE Inventory.ArticulosStock SET Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, 
			IdUnidadMedida=@IdUnidadMedida, StockMax=@StockMax, StockMin=@StockMin, PuntoReorden=@PuntoReorden, 
			UltimoCosto=@UltimoCosto, CostoPromedio=@CostoPromedio, Orden=@Orden, EAN=@EAN, Origen=@Origen, 
			IdCuenta=@IdCuenta, IdStatus=@IdStatus, IdEmpresa=@IdEmpresa, IdSucursal=@IdSucursal, LastUpdate=@LastUpdate, PCUpdate=@PCUpdate, UserUpdate=@UserUpdate
		WHERE IdArticuloStock=@ID


