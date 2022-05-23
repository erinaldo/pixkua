CREATE PROCEDURE [Sales].[ClienteContactoDEL]
	@IdCliente as int,
	@IdPersona as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.ClientesContactos WHERE IdCliente=@IdCliente AND IdPersona=@IdPersona


