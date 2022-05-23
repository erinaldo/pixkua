CREATE FUNCTION [Sales].[fxArticuloPresentacionSEL](@IdArticuloStock as int, @IdZonaVenta as int)	
RETURNS TABLE
AS
	RETURN(	
		SELECT	AX.IdArticuloStock, AX.Codigo,Ax.Nombre AS Articulo,A.IdUnidadMedida,UM.Abreviatura AS UMV,
				AZV.IdDivisa,D.Abrev AS Divisa, 0.00 AS TipoCambio,AZV.Precio,IsNull(AZV.IdImpuesto1,0)AS Impto1,IsNull(AZV.IdImpuesto2,0)AS Impto2,IsNull(AZV.IdImpuesto3,0)AS Impto3,
				IsNull(I1.Porcentaje,0) AS PorcImpto1,IsNull(I2.Porcentaje,0) AS PorcImpto2,IsNull(I3.Porcentaje,0) AS PorcImpto3			
		FROM Sales.ArticulosPresentaciones AS AP
		JOIN Sales.Articulos A 
			ON A.IdArticulo=AP.IdArticulo
		JOIN Inventory.UnidadesMedida UM 
			ON UM.IdUnidadMedida=A.IdUnidadMedida
		JOIN Inventory.ArticulosStock AX 
			ON AX.IdArticuloStock=AP.IdArticuloStock
		JOIN sales.ArticulosZonasVenta AZV 
			ON AZV.IdArticuloStock=AX.IdArticuloStock
		LEFT JOIN Accounting.Impuestos I1 
			ON I1.IdImpuesto=AZV.IdImpuesto1
		LEFT JOIN Accounting.Impuestos I2 
			ON I2.IdImpuesto=AZV.IdImpuesto2
		LEFT JOIN Accounting.Impuestos I3 
			ON I3.IdImpuesto=AZV.IdImpuesto3
		JOIN Accounting.Divisas D 
			ON D.IdDivisa=AZV.IdDivisa
	WHERE AP.IdArticuloStock=@IdArticuloStock AND AZV.IdZonaVenta=@IdZonaVenta
		)


