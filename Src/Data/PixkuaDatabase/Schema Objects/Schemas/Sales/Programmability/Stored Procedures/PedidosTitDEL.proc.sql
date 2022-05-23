-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Elimina el PedidosTit especificado.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Sales.PedidosTit WHERE IdPedidoTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


