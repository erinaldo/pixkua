-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Obtiene la información del ClasificacionesGrupos especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxClasificacionesGruposSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.ClasificacionesGrupos WHERE IdClasificacionGrupo=@ID)


