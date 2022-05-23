CREATE FUNCTION [Sales].[fxGrupoDescuentosArticulosSEL](@IdGrupoDescuento as int)
RETURNS TABLE
AS
	RETURN(	SELECT	AX.IdArticuloStock,IsNull(GDA.PorcDescuento1,0) AS PorcDescuento1,IsNull(GDA.PorcDescuento2,0) AS PorcDescuento2,IsNull(GDA.PorcDescuento3,0) AS PorcDescuento3,IsNull(GDA.PorcDescuento4,0) AS PorcDescuento4,IsNull(GDA.PorcDescuento5,0) AS PorcDescuento5,
					AX.Codigo,AX.Nombre AS Articulo
			FROM Sales.ArticulosPresentaciones AP
			LEFT  JOIN Sales.GruposDescuentoArticulos GDA ON GDA.IdArticuloStock=AP.IdArticuloStock AND GDA.IdGrupoDescuento=@IdGrupoDescuento 
			INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=AP.IdArticuloStock
			
			
)


