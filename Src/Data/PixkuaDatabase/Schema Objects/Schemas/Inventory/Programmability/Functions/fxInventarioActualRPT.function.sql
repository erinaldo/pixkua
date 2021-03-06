CREATE FUNCTION [Inventory].[fxInventarioActualRPT](@IdArea as int, @IdAlmacen as int, @IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT A.Nombre AS Almacen, AX.Codigo, AX.Nombre, AX.StockMax, AX.StockMin, AX.PuntoReorden,
		UM.Nombre AS UnidadMedia, I.Ubicacion, 
		(I.CostoPromedio * UM.Factor) AS CostoPromedio, 
		(I.CostoUltimo * UM.Factor) AS CostoUltimo,
		(I.Disponible / UM.Factor) AS Disponible, 
		(I.Apartado / UM.Factor) AS Apartado, 
		(I.Transito / um.Factor) AS Transito
	FROM Inventory.Inventario I JOIN Inventory.ArticulosStock AX
		ON I.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON AX.IdUnidadMedida=UM.IdUnidadMedida	
	JOIN Inventory.Almacenes A
		ON I.IdAlmacen=A.IdAlmacen
	JOIN Inventory.AlmacenesUsuarios AU
		ON AU.IdAlmacen=A.IdAlmacen AND AU.IdUsuario=@IdUsuario
	WHERE A.IdArea=@IdArea AND (A.IdAlmacen=@IdAlmacen OR @IdAlmacen=0)
		)


