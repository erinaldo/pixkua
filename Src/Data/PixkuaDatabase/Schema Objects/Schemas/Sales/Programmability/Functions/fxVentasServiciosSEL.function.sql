CREATE FUNCTION [Sales].[fxVentasServiciosSEL](@IdVentaTit AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT D.IdVentaDet, D.IdServicio, D.Codigo, D.Descripcion, S.ConceptoLibre, D.Cantidad, 
		T.IdDivisa, D.PrecioUnitario, D.IdPromocion, D.PorcComision, D.MontoComision, 
		D.PorcDescuento1, D.PorcDescuento2, D.PorcDescuento3, D.PorcDescuento4, D.PorcDescuento5, D.MontoDesc1, 
		D.MontoDesc2, D.MontoDesc3, D.MontoDesc4, D.MontoDesc5, D.IdImpuesto1, D.IdImpuesto2, D.IdImpuesto3, 
		D.IdImpuesto4, D.IdImpuesto5, D.PorcImpTras1, D.PorcImpTras2, D.PorcImpTras3, D.PorcImpTras4, D.PorcImpTras5,
		D.MontoImpTras1, D.MontoImpTras2, D.MontoImpTras3, D.MontoImpTras4, D.MontoImpTras5, D.PorcImpRet1, 
		D.PorcImpRet2, D.PorcImpRet3, D.PorcImpRet4, D.PorcImpRet5, D.MontoImpRet1, D.MontoImpRet2, D.MontoImpRet3, 
		D.MontoImpRet4, D.MontoImpRet5, D.Flete, M.Abrev AS Divisa
	FROM Sales.VentasDet D JOIN Sales.Servicios S
		ON D.IdServicio=S.IdServicio
	JOIN Sales.VentasTit T
		ON D.IdVentaTit=T.IdVentaTit AND D.Fecha=T.Fecha
	JOIN Accounting.Divisas M
		ON M.IdDivisa=T.IdDivisa
	WHERE D.IdVentaTit=@IdVentaTit and D.Fecha=Documents.fxDocumentDate(@IdVentaTit) 
	)


