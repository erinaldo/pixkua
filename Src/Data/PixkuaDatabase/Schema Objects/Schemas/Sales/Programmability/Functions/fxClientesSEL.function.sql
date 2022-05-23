-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Obtiene la información del Clientes especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxClientesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Clientes WHERE IdCliente=@ID)


