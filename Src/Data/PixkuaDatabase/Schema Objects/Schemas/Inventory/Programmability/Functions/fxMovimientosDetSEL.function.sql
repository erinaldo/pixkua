-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Obtiene la información del MovimientosDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure MovimientosDetUPD
-- =============================================
CREATE FUNCTION [Inventory].[fxMovimientosDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT D.IdArticuloStock, D.Cantidad, D.IdUnidadMedida, 
		D.CantidadBase, D.CostoUnitario, D.Flete, D.DisponibleInicial, D.DisponibleFinal, D.ApartadoInicial, 
		D.ApartadoFinal, D.TransitoInicial, D.TransitoFinal, D.ExistenciaInicial, D.ExistenciaFinal,
		AX.Codigo AS CodigoArticulo, AX.Nombre AS NombreArticulo, UM.Nombre AS UnidadMedida, UM.IdUnidadMedidaTipo,
		IsNull(I.Disponible, 0) AS ExistenciaBase, IsNull(I.Disponible / UM.Factor, 0) AS Existencia
	FROM Inventory.MovimientosDet D JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.MovimientosTit T
		ON D.IdMovimientoTit=T.IdMovimientoTit AND D.Fecha=T.Fecha
	LEFT JOIN Inventory.Inventario I
		ON I.IdAlmacen=T.IdAlmacen AND I.IdArticuloStock=D.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON D.IdUnidadMedida=UM.IdUnidadMedida
	WHERE D.IdMovimientoTit=@ID and D.Fecha = Documents.fxDocumentDate(@Id)
	)


