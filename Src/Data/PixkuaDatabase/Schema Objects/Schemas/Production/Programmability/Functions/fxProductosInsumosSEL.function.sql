CREATE FUNCTION [Production].[fxProductosInsumosSEL](@IdProducto as int)
RETURNS TABLE	
AS
	RETURN(	SELECT PIn.IdInsumo,I.Nombre AS Insumo,PIn.IdUnidadMedida,UM.Nombre AS UnidadMedida,PIn.Cantidad,PIn.IdMetaAlmacen,'' AS MetaAlmacen,PIn.PorcMerma,PIn.Opcional
			FROM Production.ProductosInsumos AS PIn
			INNER JOIN Production.Insumos I ON I.IdInsumo=PIn.IdInsumo
			INNER JOIN Inventory.UnidadesMedida UM ON UM.IdUnidadMedida=PIn.IdUnidadMedida
			WHERE PIn.IdProducto=@IdProducto
	)


