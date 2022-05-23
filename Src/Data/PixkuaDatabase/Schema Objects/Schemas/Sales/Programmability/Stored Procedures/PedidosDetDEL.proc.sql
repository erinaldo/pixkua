-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Elimina el PedidosDet especificado.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosDetDEL]
	@Id AS char(18)
AS
	SET NOCOUNT ON
	
	DELETE Sales.PedidosDet 
	WHERE IdPedidoTit=@Id  and Fecha=Documents.fxDocumentDate(@Id)


