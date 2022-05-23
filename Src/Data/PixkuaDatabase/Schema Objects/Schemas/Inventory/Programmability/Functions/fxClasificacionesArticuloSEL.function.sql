CREATE FUNCTION [Inventory].[fxClasificacionesArticuloSEL](@IdArticuloStock AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT CG.IdClasificacionGrupo AS IdGrupo, CG.Nombre AS Grupo, CG.Requerido, IsNull(CL.IdClasificacion, 0) AS IdClasificacion
	FROM Inventory.ClasificacionesGrupos CG LEFT JOIN 
		(	SELECT C.IdClasificacionGrupo, C.IdClasificacion
			FROM Inventory.Clasificaciones C JOIN Inventory.ClasificacionesArticulos CA 
				ON C.IdClasificacion=CA.IdClasificacion
			WHERE CA.IdArticuloStock=@IdArticuloStock
		) AS CL
		ON CL.IdClasificacionGrupo=CG.IdClasificacionGrupo
	WHERE CG.IdClasificacionEntidad=1 AND CG.IdStatus=1
		)


