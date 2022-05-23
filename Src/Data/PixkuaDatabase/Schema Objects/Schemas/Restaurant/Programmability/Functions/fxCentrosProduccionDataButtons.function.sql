CREATE FUNCTION [Restaurant].[fxCentrosProduccionDataButtons](@IdSucursal as int)
RETURNS TABLE
RETURN(SELECT IdCentroProduccion as Id,Nombre as CentroProduccion,Imagen FROM Restaurant.CentrosProduccion)


