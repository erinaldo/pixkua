CREATE FUNCTION [dbo].[fxFormatosSEL](@IdFormato as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdFormato, Nombre, IdSucursal, IdEmpresa, Formato, DataSourceXSD
	FROM dbo.Formatos
	WHERE IdFormato=@IdFormato
		)


