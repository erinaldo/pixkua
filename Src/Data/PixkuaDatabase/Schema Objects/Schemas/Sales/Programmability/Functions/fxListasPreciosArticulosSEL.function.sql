CREATE FUNCTION [Sales].[fxListasPreciosArticulosSEL](@IdListaPrecio as int)
RETURNS TABLE
AS
	RETURN(	SELECT AX.IdArticuloStock,IsNull(LPA.Precio,0) AS Precio,IsNull(LPA.IdDivisa,1)AS IdDivisa,AX.Codigo,AX.Nombre AS Articulo--,D.Nombre AS Divisa
			FROM Sales.ArticulosPresentaciones AP
			LEFT  JOIN Sales.ListasPreciosArticulos LPA ON LPA.IdArticuloStock=AP.IdArticuloStock AND LPA.IdListaPrecio=@IdListaPrecio 
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=AP.IdArticuloStock
			LEFT JOIN Accounting.Divisas D ON D.IdDivisa=LPA.IdDivisa
			
)


