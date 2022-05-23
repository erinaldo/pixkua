CREATE FUNCTION [Inventory].[fxInventarioSEL](@IdAlmacen as int, @IdArticuloStock as int)
RETURNS TABLE
AS
RETURN	(
	SELECT Disponible, Apartado, Transito, CostoPromedio, CostoUltimo, Ubicacion
	FROM Inventory.Inventario with (readuncommitted)
	WHERE IdAlmacen=@IdAlmacen AND IdArticuloStock=@IdArticuloStock
		)


