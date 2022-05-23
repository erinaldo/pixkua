-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene la información del PedidosTit especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Sales.PedidosTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdPedidoTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


