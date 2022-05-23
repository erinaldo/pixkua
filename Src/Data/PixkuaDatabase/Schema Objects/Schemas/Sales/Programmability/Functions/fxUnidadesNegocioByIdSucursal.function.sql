CREATE FUNCTION [Sales].[fxUnidadesNegocioByIdSucursal](@IdSucursal as int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.UnidadesNegocio WHERE IdSucursal=@IdSucursal)


