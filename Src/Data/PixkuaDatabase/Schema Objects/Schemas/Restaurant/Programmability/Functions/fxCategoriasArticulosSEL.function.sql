CREATE FUNCTION [Restaurant].[fxCategoriasArticulosSEL](@IdCategoria as int)
RETURNS TABLE
AS
	RETURN( SELECT A.IdArticulo, AX.Nombre AS Articulo,0 as IdCentroProduccionArticulo
			FROM Restaurant.Articulos A
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
			WHERE A.IdCategoria=@IdCategoria
	)


