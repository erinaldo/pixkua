CREATE FUNCTION [Inventory].[fxInventarioFisicoSEL](@IdArea as int)
RETURNS TABLE
AS
RETURN	(
	SELECT I.IdAlmacen, I.IdArticuloStock, AL.Nombre AS Almacen, AX.Codigo AS CodigoArticulo, AX.Nombre AS NombreArticulo,
		AX.IdUnidadMedida, UM.IdUnidadMedidaTipo, UM.Nombre AS UnidadMedida, UM.Factor, 
		IsNull(F.Teorico, (I.Disponible + I.Apartado) / UM.Factor) AS Teorico, IsNull(F.Fisico, 0) AS Fisico,
		I.CostoPromedio * UM.Factor AS CostoPromedio, I.CostoUltimo * UM.Factor AS CostoUltimo
	FROM Inventory.Inventario I JOIN Inventory.ArticulosStock AX
		ON I.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON AX.IdUnidadMedida=UM.IdUnidadMedida
	JOIN Inventory.Almacenes AL
		ON I.IdAlmacen=AL.IdAlmacen
	JOIN Inventory.Areas A
		ON AL.IdArea=A.IdArea
	LEFT JOIN Inventory.InventarioFisico F
		ON I.IdArticuloStock=F.IdArticuloStock AND I.IdAlmacen=F.IdAlmacen AND F.IdCorte=A.IdCorteActual
	WHERE A.IdArea=@IdArea AND AL.ReqCapturaFisico=1
	)


