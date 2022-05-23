-- =============================================
-- Author: RCO
-- Create date: 15-oct-2010
-- Description:	Obtiene la información del Marcas especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxMarcasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Marcas WHERE IdMarca=@ID)


