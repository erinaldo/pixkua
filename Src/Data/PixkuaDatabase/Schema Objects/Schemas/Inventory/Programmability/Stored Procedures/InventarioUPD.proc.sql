CREATE PROCEDURE [Inventory].[InventarioUPD]
	@IdAlmacen as int,
	@IdArticuloStock as int,
	@Disponible as decimal(19,6),
	@Apartado as decimal(19,6),
	@Transito as decimal(19,6),
	@Direccion as int,
	@UserUpdate as int,
	@LastUpdate as datetime,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
		
	IF EXISTS(SELECT IdAlmacen FROM Inventory.Inventario WHERE IdArticuloStock=@IdArticuloStock AND IdAlmacen=@IdAlmacen)
	BEGIN
		UPDATE Inventory.Inventario SET Disponible=Disponible + (@Disponible * @Direccion), 
			Apartado=Apartado + (@Apartado * @Direccion), 
			Transito=Transito + (@Transito * @Direccion), 
			UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate = @LastUpdate
		WHERE IdArticuloStock=@IdArticuloStock AND IdAlmacen=@IdAlmacen
	END
	ELSE
		INSERT INTO Inventory.Inventario (IdArticuloStock, IdAlmacen, Disponible, Apartado, Transito,
			UserUpdate, LastUpdate, PCUpdate)
		VALUES (@IdArticuloStock, @IdAlmacen, @Disponible, @Apartado, @Transito,
			@UserUpdate, @LastUpdate, @PCUpdate)


