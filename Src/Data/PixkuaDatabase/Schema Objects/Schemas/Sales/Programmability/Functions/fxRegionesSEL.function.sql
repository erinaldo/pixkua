-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene la información del Regiones especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxRegionesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Regiones WHERE IdRegion=@ID)


