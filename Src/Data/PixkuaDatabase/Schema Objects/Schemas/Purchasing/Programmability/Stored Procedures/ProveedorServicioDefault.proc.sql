CREATE PROCEDURE [Purchasing].[ProveedorServicioDefault]
	@IdZonaCompra as int,
	@IdProveedor as int,
	@IdServicio as int
AS
	SET NOCOUNT ON
	
	/*Quitar la marca de predeterminado de los demás proveedores de la zona*/
	UPDATE Purchasing.ProveedoresServicios SET Predeterminado=0
	WHERE IdServicio=@IdServicio AND IdZonaCompra=@IdZonaCompra
	
	/*Marcar este proveedor como predeterminado*/
	UPDATE Purchasing.ProveedoresServicios SET Predeterminado=1
	WHERE IdServicio=@IdServicio AND IdZonaCompra=@IdZonaCompra 
		AND IdProveedor=@IdProveedor


