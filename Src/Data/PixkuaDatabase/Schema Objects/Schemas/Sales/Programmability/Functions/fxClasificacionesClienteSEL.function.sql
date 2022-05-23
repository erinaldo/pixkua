CREATE FUNCTION [Sales].[fxClasificacionesClienteSEL](@IdCliente AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT CG.IdClasificacionGrupo AS IdGrupo, CG.Nombre AS Grupo, CG.Requerido, IsNull(CL.IdClasificacion, 0) AS IdClasificacion
	FROM Sales.ClasificacionesGrupos CG LEFT JOIN 
		(	SELECT C.IdClasificacionGrupo, C.IdClasificacion
			FROM Sales.Clasificaciones C JOIN Sales.ClasificacionesClientes CA 
				ON C.IdClasificacion=CA.IdClasificacion
			WHERE CA.IdCliente=@IdCliente
		) AS CL
		ON CL.IdClasificacionGrupo=CG.IdClasificacionGrupo
	WHERE CG.IdClasificacionEntidad=1 AND CG.IdStatus=1
		)


