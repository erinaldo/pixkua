CREATE PROCEDURE [Inventory].[InventarioFisicoUPD]
	@IdCorte as uniqueidentifier,
	@IdAlmacen as int,
	@IdArticuloStock as int,
	@Teorico as decimal(19,4),
	@Fisico as decimal(19,4)
AS
	SET NOCOUNT ON
	
	IF EXISTS (SELECT IdCorte FROM Inventory.InventarioFisico WHERE IdCorte=@IdCorte AND IdAlmacen=@IdAlmacen AND IdArticuloStock=@IdArticuloStock)
		UPDATE Inventory.InventarioFisico SET Teorico=@Teorico, Fisico=@Fisico
		WHERE IdCorte=@IdCorte AND IdAlmacen=@IdAlmacen AND IdArticuloStock=@IdArticuloStock		
	ELSE
		INSERT INTO Inventory.InventarioFisico (IdCorte, IdAlmacen, IdArticuloStock, Teorico, Fisico)
		VALUES (@IdCorte, @IdAlmacen, @IdArticuloStock, @Teorico, @Fisico)


