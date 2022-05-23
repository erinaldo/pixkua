-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Elimina el ClasificacionesGrupos especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[ClasificacionesGruposDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.ClasificacionesGrupos WHERE IdClasificacionGrupo=@ID


