CREATE FUNCTION [Purchasing].[fxProveedorArticulosList](@IdZonaCompra as int, @IdProveedor as int)
RETURNS TABLE
AS
RETURN	(
	SELECT PA.IdArticuloStock, AX.Codigo, AX.Nombre, PA.Costo, D.Nombre AS Divisa, UM.Nombre AS UnidadMedida,
		PA.DiasEntrega, PA.DiasCredito, ISNULL(I1.Abrev, '') AS Impuesto1, ISNULL(I2.Abrev, '') AS Impuesto2,
		ISNULL(I3.Abrev, '') AS Impuesto3, PA.IdImpuesto1, PA.IdImpuesto2, PA.IdImpuesto3, PA.PorcDescuento1,
		PA.PorcDescuento2, PA.PorcDescuento3
	FROM Purchasing.ProveedoresArticulos PA JOIN Inventory.ArticulosStock AX
		ON PA.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON PA.IdUnidadMedida=UM.IdUnidadMedida
	JOIN Accounting.Divisas D
		ON PA.IdDivisa=D.IdDivisa
	LEFT JOIN Accounting.Impuestos I1
		ON PA.IdImpuesto1=I1.IdImpuesto
	LEFT JOIN Accounting.Impuestos I2
		ON PA.IdImpuesto2=I2.IdImpuesto
	LEFT JOIN Accounting.Impuestos I3
		ON PA.IdImpuesto3=I3.IdImpuesto
	WHERE PA.IdZonaCompra=@IdZonaCompra AND PA.IdProveedor=@IdProveedor
		)


