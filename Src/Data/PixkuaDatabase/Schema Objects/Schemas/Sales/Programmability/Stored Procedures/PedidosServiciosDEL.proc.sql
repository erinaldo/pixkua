-- =============================================
-- Author: RCO
-- Create date: 25-sep-2011
-- Description:	Elimina el servicio especificado del pedido.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosServiciosDEL]
	@IdPedidoTit AS char(18),
	@IdServicio as int,
	@IdPedidoDet as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.PedidosDet 
	WHERE IdPedidoTit=@IdPedidoTit and Fecha=Documents.fxDocumentDate(@IdPedidoTit)
		AND IdArticuloStock=0 and IdServicio=@IdServicio and IdPedidoDet=@IdPedidoDet


