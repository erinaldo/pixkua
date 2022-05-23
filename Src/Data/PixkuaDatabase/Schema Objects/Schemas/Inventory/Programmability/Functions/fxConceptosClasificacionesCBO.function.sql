CREATE FUNCTION [Inventory].[fxConceptosClasificacionesCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdConceptoClasificacion, Codigo, Nombre
	FROM Inventory.ConceptosClasificaciones
	WHERE IdStatus=1
		)


