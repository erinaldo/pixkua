CREATE FUNCTION [Purchasing].[fxProveedorArticuloSEL](@IdZonaCompra as int, @IdProveedor as int, @IdArticuloStock as int)
RETURNS TABLE
AS
RETURN	(
	SELECT PA.IdZonaCompra, PA.IdProveedor, PA.IdArticuloStock, PA.IdDivisa, PA.Costo, PA.DiasCredito, PA.DiasEntrega,
		PA.IdUnidadMedida, PA.IdImpuesto1, PA.IdImpuesto2, PA.IdImpuesto3, PA.IdRetencion1, PA.IdRetencion2, PA.IdRetencion3,
		PA.PorcDescuento1, PA.PorcDescuento2, PA.PorcDescuento3, PA.Predeterminado
	FROM Purchasing.ProveedoresArticulos PA
	WHERE PA.IdZonaCompra=@IdZonaCompra AND PA.IdProveedor=@IdProveedor AND PA.IdArticuloStock=@IdArticuloStock
		)


