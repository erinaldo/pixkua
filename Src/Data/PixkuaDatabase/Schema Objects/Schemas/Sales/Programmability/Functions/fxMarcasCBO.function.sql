CREATE FUNCTION [Sales].[fxMarcasCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdMarca, Codigo, Nombre
	FROM Sales.Marcas
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


