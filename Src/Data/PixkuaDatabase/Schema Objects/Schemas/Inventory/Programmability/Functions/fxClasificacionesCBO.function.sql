CREATE FUNCTION [Inventory].[fxClasificacionesCBO](@IdEntidad as int)
RETURNS TABLE
AS
RETURN	(
	SELECT C.IdClasificacion, C.IdClasificacionGrupo, C.Nombre
	FROM Inventory.Clasificaciones C JOIN Inventory.ClasificacionesGrupos CG
		ON C.IdClasificacionGrupo=CG.IdClasificacionGrupo
	WHERE CG.IdClasificacionEntidad=@IdEntidad
		)


