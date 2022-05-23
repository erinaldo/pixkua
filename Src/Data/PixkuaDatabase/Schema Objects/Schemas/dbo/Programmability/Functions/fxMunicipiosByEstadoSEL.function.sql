CREATE FUNCTION [dbo].[fxMunicipiosByEstadoSEL](@IdEstado as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdMunicipio, Codigo, Nombre AS Municipio
	FROM dbo.Municipios
	WHERE IdEstado=@IdEstado
		)


