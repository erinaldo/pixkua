CREATE PROCEDURE [Sales].[ClienteContactoUPD]
	@IdCliente as int,
	@IdPersona as int
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdCliente FROM Sales.ClientesContactos WHERE IdCliente=@IdCliente AND IdPersona=@IdPersona)
		INSERT INTO Sales.ClientesContactos(IdCliente, IdPersona)
		VALUES (@IdCliente, @IdPersona)


