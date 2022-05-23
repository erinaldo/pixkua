-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene la información del DevolucionesCausas especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxDevolucionesCausasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.DevolucionesCausas WHERE IdDevolucionCausa=@ID)


