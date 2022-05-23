CREATE PROCEDURE [Inventory].[AlmacenAccesosDEL]
	@IdAlmacen as int,
	@IdUsuario as int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.AlmacenesUsuarios 
	WHERE IdAlmacen=@IdAlmacen AND IdUsuario=@IdUsuario


