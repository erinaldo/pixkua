-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Obtiene una lista de búsqueda de VentasTit
-- =============================================
CREATE FUNCTION [Sales].[fxVentasTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdVentaTit, Fecha, IdVentaTit AS Folio, S.StatusApplied AS Estatus, C.Codigo AS [Codigo Cliente], 
		C.Nombre AS [Nombre Cliente], C.RFC, C.RazonSocial AS [Razón Social], T.SerieFactura AS [Serie Factura],
		T.FolioFactura AS [Folio Factura], T.FechaFactura AS [Fecha Factura]
	FROM Sales.VentasTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	JOIN Sales.Clientes C
		ON T.IdCliente=C.IdCliente
	WHERE T.IdSucursal=@IdSucursal
		)


