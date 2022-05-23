CREATE FUNCTION [Purchasing].[fxProveedorServicioSEL](@IdZonaCompra int, @IdProveedor as int, @IdServicio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT PS.IdZonaCompra, PS.IdProveedor, PS.IdServicio, PS.IdDivisa, PS.Costo, PS.DiasCredito, PS.DiasEntrega,
		PS.IdImpuesto1, PS.IdImpuesto2, PS.IdImpuesto3, PS.IdRetencion1, PS.IdRetencion2, PS.IdRetencion3,
		PS.PorcDescuento1, PS.PorcDescuento2, PS.PorcDescuento3, PS.Predeterminado
	FROM Purchasing.ProveedoresServicios PS
	WHERE PS.IdZonaCompra=@IdZonaCompra AND PS.IdProveedor=@IdProveedor AND PS.IdServicio=@IdServicio	
		)


