CREATE FUNCTION [dbo].[fxModulosCategoriasCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdModuloCategoria, Nombre
	FROM dbo.ModulosCategorias	
		)


