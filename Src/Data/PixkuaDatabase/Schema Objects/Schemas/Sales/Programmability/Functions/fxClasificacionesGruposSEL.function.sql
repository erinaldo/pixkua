-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Obtiene la información del ClasificacionesGrupos especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxClasificacionesGruposSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.ClasificacionesGrupos WHERE IdClasificacionGrupo=@ID)


