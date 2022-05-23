-- =============================================
-- Author: RCO
-- Create date: 11-nov-2010
-- Description:	Obtiene la información del ConceptosClasificaciones especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxConceptosClasificacionesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.ConceptosClasificaciones WHERE IdConceptoClasificacion=@ID)


