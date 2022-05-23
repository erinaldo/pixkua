-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Elimina el PedidosTipos especificado.
-- =============================================
CREATE PROCEDURE [Sales].[PedidosTiposDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.PedidosTipos WHERE IdPedidoTipo=@ID


