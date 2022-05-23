CREATE FUNCTION [Restaurant].[fxCategoriasLoadButtons](@IdSucursal as int)
RETURNS TABLE
RETURN(SELECT IdCategoria,Nombre,Imagen,Color FROM Restaurant.Categorias )


