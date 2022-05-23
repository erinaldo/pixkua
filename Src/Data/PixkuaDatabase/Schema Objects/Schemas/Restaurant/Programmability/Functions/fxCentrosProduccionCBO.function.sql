CREATE FUNCTION [Restaurant].[fxCentrosProduccionCBO](@IdSucursal as int)
RETURNS TABLE
RETURN(SELECT IdCentroProduccion as Id,Nombre as CentroProduccion FROM Restaurant.CentrosProduccion)


