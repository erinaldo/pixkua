-- =============================================
-- Author: RCO
-- Create date: 11-nov-2010
-- Description:	Elimina el ConceptosClasificaciones especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[ConceptosClasificacionesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.ConceptosClasificaciones WHERE IdConceptoClasificacion=@ID


