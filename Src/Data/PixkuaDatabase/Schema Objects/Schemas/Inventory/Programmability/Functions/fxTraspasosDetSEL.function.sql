-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Obtiene la información del TraspasosDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure TraspasosDetUPD
-- =============================================
CREATE FUNCTION [Inventory].[fxTraspasosDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT D.IdArticuloStock, D.CantidadEnviada, D.CantidadRecibida, D.IdUnidadMedida, D.CostoUnitario, D.Flete,
		AX.Codigo AS CodigoArticulo, AX.Nombre AS NombreArticulo, UM.Nombre AS UnidadMedida, UM.IdUnidadMedidaTipo,
		IsNull(I.Disponible, 0) AS ExistenciaBase, IsNull(I.Disponible / UM.Factor, 0) AS Existencia
	FROM Inventory.TraspasosDet D JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.TraspasosTit T
		ON D.IdTraspasoTit=T.IdTraspasoTit AND D.Fecha=T.Fecha
	LEFT JOIN Inventory.Inventario I
		ON I.IdAlmacen=T.IdAlmacenOrigen AND I.IdArticuloStock=D.IdArticuloStock		
	JOIN Inventory.UnidadesMedida UM
		ON D.IdUnidadMedida=UM.IdUnidadMedida
	WHERE D.IdTraspasoTit=@ID and D.Fecha = Documents.fxDocumentDate(@Id)
	)


