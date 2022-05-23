CREATE PROCEDURE [Purchasing].[ProveedorArticuloDefault]
	@IdZonaCompra as int,
	@IdProveedor as int,
	@IdArticuloStock as int
AS
	SET NOCOUNT ON
	
	/*Quitar la marca de predeterminado de los demás proveedores de la zona*/
	UPDATE Purchasing.ProveedoresArticulos SET Predeterminado=0
	WHERE IdArticuloStock=@IdArticuloStock AND IdZonaCompra=@IdZonaCompra
	
	/*Marcar este proveedor como predeterminado*/
	UPDATE Purchasing.ProveedoresArticulos SET Predeterminado=1
	WHERE IdArticuloStock=@IdArticuloStock AND IdZonaCompra=@IdZonaCompra 
		AND IdProveedor=@IdProveedor


