-- =============================================
-- Author: alez Lopez
-- Create date: 16-ago-2011
-- Description:	Obtiene la información del ListasPrecios especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxListasPreciosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.ListasPrecios WHERE IdListaPrecio=@ID)


