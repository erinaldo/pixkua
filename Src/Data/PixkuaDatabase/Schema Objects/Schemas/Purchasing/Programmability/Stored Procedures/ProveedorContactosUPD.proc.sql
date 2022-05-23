CREATE PROCEDURE [Purchasing].[ProveedorContactosUPD]
	@IdProveedor as int,
	@IdPersona as int
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdProveedor FROM Purchasing.ProveedoresContactos WHERE IdPersona=@IdPersona AND IdProveedor=@IdProveedor)
		INSERT INTO Purchasing.ProveedoresContactos(IdProveedor, IdPersona)
		VALUES (@IdProveedor, @IdPersona)


