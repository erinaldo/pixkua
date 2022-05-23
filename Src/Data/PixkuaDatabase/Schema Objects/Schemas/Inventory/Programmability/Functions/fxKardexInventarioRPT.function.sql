CREATE FUNCTION [Inventory].[fxKardexInventarioRPT](@IdAlmacen as int, @FechaIni as datetime, @FechaFin as datetime, @IdArticuloStock as int)
RETURNS TABLE
AS
RETURN	(
SELECT T.IdMovimientoTit, T.HoraMovto, T.Direccion, T.Referencia, C.Nombre AS Concepto, 
	AX.Codigo AS CodigoArticulo, AX.Nombre AS NombreArticulo, UM.Nombre AS UnidadMedida,
	D.CostoUnitario, D.CantidadBase / UM.Factor AS Cantidad, 
	D.ExistenciaInicial / UM.Factor AS ExistenciaInicial, 
	D.ExistenciaFinal / UM.Factor AS ExistenciaFinal
FROM Inventory.MovimientosTit T JOIN Inventory.Conceptos C
	ON T.IdConcepto=C.IdConcepto
JOIN Inventory.MovimientosDet D
	ON T.IdMovimientoTit=D.IdMovimientoTit AND T.Fecha=D.Fecha
JOIN Inventory.ArticulosStock AX
	ON D.IdArticuloStock=AX.IdArticuloStock
JOIN Inventory.UnidadesMedida UM
	ON AX.IdUnidadMedida=UM.IdUnidadMedida
WHERE T.IdAlmacen=@IdAlmacen AND (D.IdArticuloStock=@IdArticuloStock OR @IdArticuloStock=0)
	AND T.HoraMovto between @FechaIni and @FechaFin
	AND T.Fecha between dateadd(dd, -15, @FechaIni) and @FechaFin
	AND  T.IdStatus > 2
		)


