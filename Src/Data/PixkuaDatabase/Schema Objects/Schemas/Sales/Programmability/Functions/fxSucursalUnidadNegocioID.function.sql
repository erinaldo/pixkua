CREATE FUNCTION [Sales].[fxSucursalUnidadNegocioID](@IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @IdUnidadNegocio as int
	
	SELECT @IdUnidadNegocio=IdUnidadNegocio
	FROM Sales.UnidadesNegocio
	WHERE IdSucursal=@IdSucursal
	
	RETURN IsNull(@IdUnidadNegocio, 0)
END


