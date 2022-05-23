-- =============================================
-- Author: RCO
-- Create date: 03-sep-2010
-- Description:	Obtiene la información del UnidadesNegocio especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxUnidadesNegocioSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.UnidadesNegocio WHERE IdUnidadNegocio=@ID)


