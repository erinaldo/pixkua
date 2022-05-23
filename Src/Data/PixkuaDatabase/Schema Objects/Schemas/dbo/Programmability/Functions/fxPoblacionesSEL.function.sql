-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 21-Mar-2006
-- Description:	Obtiene la información de la población especificada.
-- =============================================
CREATE FUNCTION [dbo].[fxPoblacionesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT P.*, M.Nombre AS Municipio, M.IdEstado, E.Estado, PA.Pais, E.IdPais
	FROM dbo.Poblaciones P JOIN Municipios M
		ON P.IdMunicipio=M.IdMunicipio
	JOIN dbo.Estados E
		ON M.IdEstado=E.IdEstado
	JOIN dbo.Paises PA
		ON E.IdPais=PA.IdPais
	WHERE P.IdPoblacion=@ID
	)


