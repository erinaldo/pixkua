CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesArticulosSEL](@IdCategoriaPresupuestal int)
RETURNS TABLE
AS
RETURN(	SELECT CA.IdArticuloStock,AX.Codigo,AX.Nombre AS Articulo
		FROM Purchasing.CategoriasPresupuestalesArticulos CA
		INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=CA.IdArticuloStock
		WHERE CA.IdCategoriaPresupuestal=@IdCategoriaPresupuestal
)


