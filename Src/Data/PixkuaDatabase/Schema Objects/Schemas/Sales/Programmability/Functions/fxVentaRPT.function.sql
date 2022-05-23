CREATE FUNCTION [Sales].[fxVentaRPT](@IdVentaTit as char(18))
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdVentaTit, T.Fecha, C.Codigo AS CodigoCliente, C.Nombre AS NombreCliente, C.RFC, C.RazonSocial,
		T.SubTotal, T.TotalDescuentos, T.TotalImpuestosRet, T.TotalImpuestosTras,
		T.Total, T.CondicionesPago, Ca.Nombre AS Caja,
		D.Cantidad, D.Codigo AS CodigoConcepto, D.Descripcion AS DescripcionConcepto,
		D.PrecioUnitario AS PrecioUnitario, T.TipoCambio, DV.Nombre AS Divisa, DV.Abrev AS DivisaAbrev,
		S.StatusApplied AS Estatus
	FROM Sales.VentasTit T 
		JOIN Sales.VentasDet D 
			ON T.IdVentaTit=D.IdVentaTit AND T.Fecha=D.Fecha
		JOIN Sales.Clientes C  
			ON T.IdCliente=C.IdCliente		
		JOIN Accounting.Divisas DV 
			ON T.IdDivisa=DV.IdDivisa
		JOIN Documents.[Status] S
			ON T.IdStatus=S.IdStatus
		LEFT JOIN Sales.Cajas Ca
			ON T.IdCaja=Ca.IdCaja
	WHERE T.IdVentaTit=@IdVentaTit AND T.Fecha=Documents.fxDocumentDate(@IdVentaTit)
		)


