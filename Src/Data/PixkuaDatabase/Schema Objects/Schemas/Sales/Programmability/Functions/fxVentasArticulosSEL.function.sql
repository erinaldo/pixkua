CREATE FUNCTION [Sales].[fxVentasArticulosSEL](@IdVentaTit as char(18), @IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT D.IdArticuloStock, D.Codigo, D.Descripcion, D.Cantidad, D.IdUnidadMedida, UM.IdUnidadMedidaTipo,
		D.PrecioUnitario, T.IdDivisa, D.IdPromocion, D.PorcComision, D.MontoComision, 
		D.PorcDescuento1, D.PorcDescuento2, D.PorcDescuento3, D.PorcDescuento4, D.PorcDescuento5, D.MontoDesc1, 
		D.MontoDesc2, D.MontoDesc3, D.MontoDesc4, D.MontoDesc5, D.IdImpuesto1, D.IdImpuesto2, D.IdImpuesto3, 
		D.IdImpuesto4, D.IdImpuesto5, D.PorcImpTras1, D.PorcImpTras2, D.PorcImpTras3, D.PorcImpTras4, D.PorcImpTras5,
		D.MontoImpTras1, D.MontoImpTras2, D.MontoImpTras3, D.MontoImpTras4, D.MontoImpTras5, D.PorcImpRet1, 
		D.PorcImpRet2, D.PorcImpRet3, D.PorcImpRet4, D.PorcImpRet5, D.MontoImpRet1, D.MontoImpRet2, D.MontoImpRet3, 
		D.MontoImpRet4, D.MontoImpRet5, D.Flete, UM.Nombre AS UnidadMedida, 
		IsNull(I.Disponible, 0) AS ExistenciaBase, IsNull(I.Disponible / UM.Factor, 0) AS Existencia		
	FROM Sales.VentasDet D JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON D.IdUnidadMedida=UM.IdUnidadMedida
	JOIN Sales.VentasTit T
		ON D.IdVentaTit=T.IdVentaTit AND D.Fecha=T.Fecha
	JOIN Sales.UnidadesNegocio UN
		ON UN.IdSucursal=T.IdSucursal
	LEFT JOIN Inventory.Inventario I
		ON I.IdAlmacen=UN.IdAlmacen AND I.IdArticuloStock=D.IdArticuloStock				
	WHERE D.IdVentaTit=@IdVentaTit and D.Fecha=Documents.fxDocumentDate(@IdVentaTit) 
		)


