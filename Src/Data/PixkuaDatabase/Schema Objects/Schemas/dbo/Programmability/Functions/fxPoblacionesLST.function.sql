-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: <<FECHA>>
-- Description:	Obtiene una lista de búsqueda de <<>>
-- =============================================
CREATE FUNCTION [dbo].[fxPoblacionesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT P.IdPoblacion, P.Poblacion, M.Nombre AS Municipio, E.Estado, PS.Pais
	FROM dbo.Poblaciones P JOIN Municipios M
		ON P.IdMunicipio=M.IdMunicipio
	JOIN dbo.Estados E
		ON M.IdEstado=E.IdEstado
	JOIN dbo.Paises PS
		ON E.IdPais=PS.IdPais
	)


