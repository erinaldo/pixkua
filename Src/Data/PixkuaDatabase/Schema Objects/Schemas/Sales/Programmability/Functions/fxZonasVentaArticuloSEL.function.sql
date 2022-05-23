CREATE FUNCTION [Sales].[fxZonasVentaArticuloSEL](@IdZonaVenta as int)
RETURNS TABLE
AS
	RETURN (	SELECT AZ.*,AX.Codigo AS CodigoArticulo, AX.Nombre AS NombreArticulo, D.Nombre AS Divisa,
							I1.Abrev AS Impuesto1, I2.Abrev AS Impuesto2, I3.Abrev AS Impuesto3
				FROM Sales.ArticulosZonasVenta AZ 
				INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=AZ.IdArticuloStock
				JOIN Accounting.Divisas D ON AZ.IdDivisa=D.IdDivisa
				LEFT JOIN Accounting.Impuestos I1 ON I1.IdImpuesto=AZ.IdImpuesto1
				LEFT JOIN Accounting.Impuestos I2 ON I2.IdImpuesto=AZ.IdImpuesto2
				LEFT JOIN Accounting.Impuestos I3 ON I3.IdImpuesto=AZ.IdImpuesto3		
				WHERE IdZonaVenta=@IdZonaVenta
			)


