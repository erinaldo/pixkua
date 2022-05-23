-- =============================================
-- Author: RCO
-- Create date: 13-oct-2010
-- Description:	Obtiene una lista de búsqueda de Conceptos
-- =============================================
CREATE FUNCTION [Inventory].[fxConceptosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdConcepto, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.Conceptos
	)


