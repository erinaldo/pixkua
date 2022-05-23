CREATE FUNCTION [Purchasing].[fxServicioProveedoresList](@IdZonaCompra as int, @IdServicio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT PS.IdProveedor, P.Codigo, P.Nombre, P.RFC, P.RazonSocial, PS.Costo, D.Nombre AS Divisa,
			PS.DiasEntrega, PS.DiasCredito, ISNULL(I1.Abrev, '') AS Impuesto1, ISNULL(I2.Abrev, '') AS Impuesto2,
			ISNULL(I3.Abrev, '') AS Impuesto3, PS.IdImpuesto1, PS.IdImpuesto2, PS.IdImpuesto3, PS.PorcDescuento1,
			PS.PorcDescuento2, PS.PorcDescuento3, PS.IdRetencion1, PS.IdRetencion2, PS.IdRetencion3, 
			ISNULL(R1.Abrev, '') AS Retencion1, ISNULL(R2.Abrev, '') AS Retencion2, ISNULL(R3.Abrev, '') AS Retencion3, 
			PS.Predeterminado, 
			CASE PS.Predeterminado 
				WHEN 1 THEN 'SI'
				WHEN 0 THEN 'NO'			
			END AS PredeterminadoDescr
	FROM Purchasing.ProveedoresServicios PS JOIN Purchasing.Proveedores P
		ON PS.IdProveedor=P.IdProveedor
	JOIN Accounting.Divisas D
		ON PS.IdDivisa=D.IdDivisa
	LEFT JOIN Accounting.Impuestos I1
		ON PS.IdImpuesto1=I1.IdImpuesto
	LEFT JOIN Accounting.Impuestos I2
		ON PS.IdImpuesto2=I2.IdImpuesto
	LEFT JOIN Accounting.Impuestos I3
		ON PS.IdImpuesto3=I3.IdImpuesto
	LEFT JOIN Accounting.Retenciones R1
		ON PS.IdRetencion1=R1.IdRetencion
	LEFT JOIN Accounting.Retenciones R2
		ON PS.IdRetencion2=R2.IdRetencion
	LEFT JOIN Accounting.Retenciones R3
		ON PS.IdRetencion3=R3.IdRetencion		
	WHERE PS.IdZonaCompra=@IdZonaCompra AND PS.IdServicio=@IdServicio
		)


