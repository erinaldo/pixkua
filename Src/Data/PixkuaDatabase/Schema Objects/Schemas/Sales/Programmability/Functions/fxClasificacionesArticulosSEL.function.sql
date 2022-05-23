CREATE FUNCTION [Sales].[fxClasificacionesArticulosSEL](@IdArticulo AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT CG.IdClasificacionGrupo AS IdGrupo, CG.Nombre AS Grupo, CG.Requerido, IsNull(CL.IdClasificacion, 0) AS IdClasificacion
	FROM Sales.ClasificacionesGrupos CG LEFT JOIN 
		(	SELECT C.IdClasificacionGrupo, C.IdClasificacion
			FROM Sales.Clasificaciones C JOIN Sales.ClasificacionesArticulos CA 
				ON C.IdClasificacion=CA.IdClasificacion
			WHERE CA.IdArticulo=@IdArticulo
		) AS CL
		ON CL.IdClasificacionGrupo=CG.IdClasificacionGrupo
	WHERE CG.IdClasificacionEntidad=2 AND CG.IdStatus=1
		)


