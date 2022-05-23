-- =============================================
-- Author: RCO
-- Create date: 11-nov-2010
-- Description:	Obtiene una lista de búsqueda de ConceptosClasificaciones
-- =============================================
CREATE FUNCTION [Inventory].[fxConceptosClasificacionesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdConceptoClasificacion, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.ConceptosClasificaciones	
	)


