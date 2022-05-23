CREATE FUNCTION [Inventory].[fxMovimientoRPT](@IdMovimientoTit as char(18))
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdMovimientoTit, T.Fecha, T.HoraMovto, T.Direccion, A.Nombre AS Almacen, C.Nombre AS Concepto,
		S.StatusApplied AS Estatus, T.Observaciones, AX.Codigo, AX.Nombre, UM.Nombre AS UnidadMedida, UM.Factor,
		D.Cantidad, D.CostoUnitario, D.Flete
	FROM Inventory.MovimientosTit T JOIN Inventory.MovimientosDet D
		ON T.IdMovimientoTit=D.IdMovimientoTit AND T.Fecha=D.Fecha
	JOIN Inventory.Almacenes A
		ON T.IdAlmacen=A.IdAlmacen
	JOIN Inventory.Conceptos C
		ON T.IdConcepto=C.IdConcepto
	JOIN Documents.Status S
		ON T.IdStatus=S.IdStatus
	JOIN Inventory.ArticulosStock AX
		ON D.IdArticuloStock=AX.IdArticuloStock
	JOIN Inventory.UnidadesMedida UM
		ON D.IdUnidadMedida=UM.IdUnidadMedida
	WHERE T.IdMovimientoTit=@IdMovimientoTit AND T.Fecha=Documents.fxDocumentDate(@IdMovimientoTit)
		)


