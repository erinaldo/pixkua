-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene la información del PedidosTipos especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosTiposSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.PedidosTipos WHERE IdPedidoTipo=@ID)


