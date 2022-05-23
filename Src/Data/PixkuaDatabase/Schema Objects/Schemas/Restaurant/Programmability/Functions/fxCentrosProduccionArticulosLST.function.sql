CREATE FUNCTION [Restaurant].[fxCentrosProduccionArticulosLST](@IdSucursal as int)
RETURNS TABLE
AS
RETURN(	SELECT CPA.IdCentroProduccion,CPA.IdArticulo
		FROM Restaurant.CentrosProduccionArticulos CPA
		INNER JOIN Restaurant.Articulos A ON A.IdArticulo=CPA.IdArticulo
		--INNER JOIN Inventory.ArticulosStock AS AX ON AX.IdArticuloStock=A.IdArticuloStock
		WHERE A.IdSucursal=@IdSucursal
)


