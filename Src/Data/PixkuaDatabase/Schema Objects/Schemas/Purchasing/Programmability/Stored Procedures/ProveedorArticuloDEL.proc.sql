CREATE PROCEDURE [Purchasing].[ProveedorArticuloDEL]
	@IdZonaCompra as int,
	@IdProveedor as int,
	@IdArticuloStock as int
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.ProveedoresArticulos 
	WHERE IdZonaCompra=@IdZonaCompra AND IdProveedor=@IdProveedor AND IdArticuloStock=@IdArticuloStock


