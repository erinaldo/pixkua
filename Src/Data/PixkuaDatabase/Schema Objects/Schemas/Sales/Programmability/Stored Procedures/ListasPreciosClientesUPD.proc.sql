CREATE PROCEDURE [Sales].[ListasPreciosClientesUPD]
@IdListaPrecios as int, 
@IdCliente as int
AS
		UPDATE Sales.Clientes 
		SET IdListaPrecio=@IdListaPrecios
		WHERE IdCliente=@IdCliente


