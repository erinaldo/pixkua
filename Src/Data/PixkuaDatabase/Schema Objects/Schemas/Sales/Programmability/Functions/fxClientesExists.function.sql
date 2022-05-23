-- =============================================
-- Author: RCO
-- Create date: 02-sep-2010
-- Description:	Verifica la existencia de Clientes
-- =============================================
CREATE FUNCTION [Sales].[fxClientesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCliente FROM Sales.Clientes WHERE IdCliente=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


