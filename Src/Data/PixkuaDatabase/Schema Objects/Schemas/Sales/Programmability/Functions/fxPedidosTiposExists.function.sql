-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Verifica la existencia de PedidosTipos
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosTiposExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPedidoTipo FROM Sales.PedidosTipos WHERE IdPedidoTipo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


