CREATE FUNCTION [Sales].[fxClasificacionesCBO](@IdEntidad as int)
RETURNS TABLE
AS
RETURN	(
	SELECT C.IdClasificacion, C.IdClasificacionGrupo, C.Nombre
	FROM Sales.Clasificaciones C JOIN Sales.ClasificacionesGrupos CG
		ON C.IdClasificacionGrupo=CG.IdClasificacionGrupo
	WHERE CG.IdClasificacionEntidad=@IdEntidad
		)


