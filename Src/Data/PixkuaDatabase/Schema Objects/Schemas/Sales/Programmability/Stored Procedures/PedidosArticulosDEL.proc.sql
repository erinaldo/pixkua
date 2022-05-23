-- =============================================
-- Author: RCO
-- Create date: 25-sep-2011
-- Description:	Elimina el artículo especificado del pedido.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosArticulosDEL]
	@IdPedidoTit AS char(18),
	@IdArticuloStock as int	
AS
	SET NOCOUNT ON
	
	DELETE Sales.PedidosDet 
	WHERE IdPedidoTit=@IdPedidoTit and Fecha=Documents.fxDocumentDate(@IdPedidoTit)
		and IdArticuloStock=@IdArticuloStock and IdServicio=0


