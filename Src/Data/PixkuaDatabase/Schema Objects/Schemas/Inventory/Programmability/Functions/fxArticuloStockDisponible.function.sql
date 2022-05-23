CREATE FUNCTION [Inventory].[fxArticuloStockDisponible](@IdArticuloStock as int, @IdAlmacen as int)
RETURNS decimal(19,6)
AS
BEGIN
	DECLARE @Result as decimal(19,6)
	
	SELECT @Result=Disponible
	FROM Inventory.Inventario with (readuncommitted)
	WHERE IdArticuloStock=@IdArticuloStock AND IdAlmacen=@IdAlmacen
	
	RETURN IsNull(@Result, 0.0)
END


