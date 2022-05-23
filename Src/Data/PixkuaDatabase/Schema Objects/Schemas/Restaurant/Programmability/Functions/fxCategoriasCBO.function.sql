CREATE FUNCTION [Restaurant].[fxCategoriasCBO](@IdSucursal as int)
RETURNS TABLE
RETURN(SELECT IdCategoria,Nombre FROM Restaurant.Categorias )


