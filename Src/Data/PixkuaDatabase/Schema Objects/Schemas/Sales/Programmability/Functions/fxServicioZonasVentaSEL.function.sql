CREATE FUNCTION [Sales].[fxServicioZonasVentaSEL](@IdServicio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT Z.IdZonaVenta, Z.Nombre AS ZonaVenta, 
		SZ.IdDivisa, D.Abrev AS Divisa, SZ.Precio, 
		SZ.DiasEntrega, SZ.IdImpuesto1, SZ.IdImpuesto2, SZ.IdImpuesto3, 
		I1.Abrev AS Impuesto1, I2.Abrev AS Impuesto2, I3.Abrev AS Impuesto3,
		SZ.PorcRetencion1, SZ.PorcRetencion2, SZ.PorcRetencion3
	FROM Sales.ZonasVenta Z JOIN Sales.ServiciosZonasVenta SZ
		ON SZ.IdZonaVenta=Z.IdZonaVenta
	JOIN Accounting.Divisas D
		ON SZ.IdDivisa=D.IdDivisa
	LEFT JOIN Accounting.Impuestos I1
		ON I1.IdImpuesto=SZ.IdImpuesto1
	LEFT JOIN Accounting.Impuestos I2
		ON I2.IdImpuesto=SZ.IdImpuesto2
	LEFT JOIN Accounting.Impuestos I3
		ON I3.IdImpuesto=SZ.IdImpuesto3		
	WHERE SZ.IdServicio=@IdServicio
		)


