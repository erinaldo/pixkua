CREATE FUNCTION [Inventory].[fxTraspasoRPT] (@IdTraspasoTit as char(18))
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdTraspasoTit, T.Fecha, T.HoraMovto, C.Nombre AS Concepto, AO.Nombre AS AlmacenOrigen, 
		AD.Nombre AS AlmacenDestino, T.Observaciones, S.StatusApplied AS Estatus,
		AX.Codigo AS CodigoArticulo, AX.Nombre AS DescrArticulo, UM.Nombre AS UnidadMedida, UM.Factor,
		D.CantidadEnviada, D.CantidadRecibida, D.CostoUnitario, D.Flete
	FROM Inventory.TraspasosTit T JOIN Inventory.Conceptos C
		ON T.IdConcepto=C.IdConcepto
	JOIN Inventory.Almacenes AO
		ON T.IdAlmacenOrigen=AO.IdAlmacen
	JOIN Inventory.Almacenes AD
		ON T.IdAlmacenDestino=AD.IdAlmacen
	JOIN Documents.Status S
		ON T.IdStatus=S.IdStatus
	JOIN Inventory.TraspasosDet D
		ON T.IdTraspasoTit=D.IdTraspasoTit AND T.Fecha=D.Fecha
	JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON D.IdUnidadMedida=UM.IdUnidadMedida
	WHERE T.IdTraspasoTit=@IdTraspasoTit AND T.Fecha=Documents.fxDocumentDate(@IdTraspasoTit)
		)


