CREATE FUNCTION [Inventory].[fxArticuloInventarioInfoSEL](@IdSucursal as int, @IdArticuloStock as int, @IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT I.IdAlmacen, I.Ubicacion, I.StockMax, I.StockMin, I.PuntoReorden
	FROM Inventory.Inventario I JOIN Inventory.AlmacenesUsuarios AU
		ON I.IdAlmacen=AU.IdAlmacen
	JOIN Inventory.Almacenes A
		ON I.IdAlmacen=A.IdAlmacen
	WHERE I.IdArticuloStock=@IdArticuloStock AND AU.IdUsuario=@IdUsuario
		AND A.IdSucursal=@IdSucursal AND A.IdStatus=1
		AND (I.Ubicacion <> '' OR I.StockMin > 0 OR I.StockMax > 0)		
		)


