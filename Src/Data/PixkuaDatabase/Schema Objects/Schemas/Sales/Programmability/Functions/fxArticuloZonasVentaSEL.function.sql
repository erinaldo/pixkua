CREATE FUNCTION [Sales].[fxArticuloZonasVentaSEL](@IdZonaVenta as int)
RETURNS TABLE
AS
	RETURN (	SELECT AZ.*,AX.Codigo AS CodigoArticulo,AX.Descripcion AS NombreArticulo
				FROM Sales.ArticulosZonasVenta AZ 
				INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=AZ.IdArticuloStock
				WHERE IdZonaVenta=@IdZonaVenta
			)


