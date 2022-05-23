CREATE PROCEDURE [Purchasing].[ProveedorContactosDEL]
	@IdProveedor as int,
	@IdPersona as int
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.ProveedoresContactos WHERE IdPersona=@IdPersona AND IdProveedor=@IdProveedor


