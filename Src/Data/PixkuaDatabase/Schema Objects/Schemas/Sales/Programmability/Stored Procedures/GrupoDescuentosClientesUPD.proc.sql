CREATE PROCEDURE [Sales].[GrupoDescuentosClientesUPD]
@IdGrupoDescuentos as int, 
@IdCliente as int
AS
		UPDATE Sales.Clientes 
		SET IdGrupoDescuentos=@IdGrupoDescuentos
		WHERE IdCliente=@IdCliente


