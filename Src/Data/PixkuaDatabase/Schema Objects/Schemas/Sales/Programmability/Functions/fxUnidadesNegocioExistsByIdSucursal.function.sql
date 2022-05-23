CREATE FUNCTION [Sales].[fxUnidadesNegocioExistsByIdSucursal](@IdSucursal as int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdUnidadNegocio FROM Sales.UnidadesNegocio WHERE IdSucursal=@IdSucursal)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


