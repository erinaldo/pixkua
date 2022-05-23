CREATE FUNCTION [Sales].[fxArticuloPresentaciones](@IdArticulo as int)
RETURNS TABLE
AS
RETURN	(
	SELECT AX.IdArticuloStock, AX.Codigo, AX.Nombre, AX.IdUnidadMedida, UM.Nombre AS UnidadMedida,
		AX.EAN, AX.StockMax, AX.StockMin, AX.PuntoReorden, AX.IdStatus, 
		CASE AX.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus	
	FROM Sales.ArticulosPresentaciones AP JOIN Inventory.ArticulosStock AX
		ON AP.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON AX.IdUnidadMedida=UM.IdUnidadMedida
	WHERE AP.IdArticulo=@IdArticulo
		)


