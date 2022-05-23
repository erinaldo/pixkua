CREATE FUNCTION [Inventory].[fxAlmacenStock](@IdAlmacen as int)
RETURNS TABLE
AS
RETURN	(
	SELECT AX.IdArticuloStock, AX.IdUnidadMedida, UM.Factor,
		(I.Disponible / UM.Factor) AS Disponible, 
		(I.Apartado / UM.Factor) AS Apartado, 
		(I.Transito / UM.Factor) AS Transito, 
		(I.CostoPromedio * UM.Factor) AS CostoPromedio, 
		(I.CostoUltimo * UM.Factor) AS CostoUltimo
	FROM Inventory.Inventario I JOIN Inventory.ArticulosStock AX
		ON I.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON AX.IdUnidadMedida=UM.IdUnidadMedida
	WHERE I.IdAlmacen=@IdAlmacen
		)


