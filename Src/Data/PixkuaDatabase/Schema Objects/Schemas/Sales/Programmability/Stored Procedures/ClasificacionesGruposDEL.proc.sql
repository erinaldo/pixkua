-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Elimina el ClasificacionesGrupos especificado.
-- =============================================
CREATE PROCEDURE [Sales].[ClasificacionesGruposDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.ClasificacionesGrupos WHERE IdClasificacionGrupo=@ID


