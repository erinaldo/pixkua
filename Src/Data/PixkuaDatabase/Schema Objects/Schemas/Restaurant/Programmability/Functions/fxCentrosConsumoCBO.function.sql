CREATE FUNCTION [Restaurant].[fxCentrosConsumoCBO](@IdSucursal as int)
RETURNS TABLE
RETURN(SELECT IdCentroConsumo,Nombre FROM Restaurant.CentrosConsumo )


