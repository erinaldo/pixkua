-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Verifica la existencia de PedidosTit
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPedidoTit FROM Sales.PedidosTit WHERE IdPedidoTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


