-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Obtiene la información del Productos especificado.
-- =============================================
CREATE FUNCTION [Production].[fxProductosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Production.Productos WHERE IdProducto=@ID)


