-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene una lista de búsqueda de PedidosTit
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosTitLST](@IdUsuario AS char(18), @IdSucursal AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.IdPedidoTit, T.Fecha, C.Codigo AS [Codigo Cliente], 
		C.Nombre AS [Nombre Cliente], C.RFC, C.RazonSocial AS [Razón Social], 
		S.[StatusApplied] AS Estatus
	FROM Sales.PedidosTit T JOIN Documents.[Status] S
		ON T.IdStatus=S.IdStatus
	JOIN Sales.Clientes C
		ON T.IdCliente=C.IdCliente		
	WHERE T.IdSucursal=@IdSucursal
		)


