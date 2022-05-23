CREATE FUNCTION [Restaurant].[fxCentrosProduccionArticulosSEL](@IdCentroProduccion as int)
RETURNS TABLE
AS
RETURN(	SELECT CPA.IdCentroProduccionArticulo,CPA.IdArticulo,CPA.LastUpdate,CPA.PCUpdate,CPA.UserUpdate, AX.Nombre AS Articulo
		FROM Restaurant.CentrosProduccionArticulos CPA
		INNER JOIN Restaurant.Articulos A ON A.IdArticulo=CPA.IdArticulo
		INNER JOIN Inventory.ArticulosStock AS AX ON AX.IdArticuloStock=A.IdArticuloStock
		WHERE CPA.IdCentroProduccion=@IdCentroProduccion
)


