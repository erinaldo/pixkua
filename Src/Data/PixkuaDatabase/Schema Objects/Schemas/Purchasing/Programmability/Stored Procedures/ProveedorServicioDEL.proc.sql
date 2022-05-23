CREATE PROCEDURE [Purchasing].[ProveedorServicioDEL]
	@IdZonaCompra as int,
	@IdProveedor as int,
	@IdServicio as int
AS
	SET NOCOUNT ON	
	
	DELETE Purchasing.ProveedoresServicios
	WHERE IdZonaCompra=@IdZonaCompra AND IdProveedor=@IdProveedor AND IdServicio=@IdServicio


