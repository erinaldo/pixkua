CREATE FUNCTION [Sales].[fxArticuloZonasVentaByArtStockSEL](@IdArticuloStock as int)
RETURNS TABLE
AS
	RETURN (	SELECT AZ.IdZonaVenta,ZV.Nombre AS ZonaVenta,Precio,AZ.IdDivisa,D.Nombre AS Divisa, DiasEntrega ,IdImpuesto1,IdImpuesto2,IdImpuesto3,PorcRetencion1,PorcRetencion2,PorcRetencion3,I1.Abrev AS Impuesto1,I2.Abrev AS Impuesto2,I3.Abrev AS Impuesto3
				FROM Sales.ArticulosZonasVenta AZ 
				INNER JOIN.Accounting.Divisas D ON D.IdDivisa=AZ.IdDivisa
				INNER JOIN Sales.ZonasVenta ZV ON ZV.IdZonaVenta=AZ.IdZonaVenta
				LEFT JOIN Accounting.Impuestos I1 ON I1.IdImpuesto=AZ.IdImpuesto1
				LEFT JOIN Accounting.Impuestos I2 ON I2.IdImpuesto=AZ.IdImpuesto2
				LEFT JOIN Accounting.Impuestos I3 ON I3.IdImpuesto=AZ.IdImpuesto3
				WHERE AZ.IdArticuloStock=@IdArticuloStock
			)


