-- =============================================
-- Author: RCO
-- Create date: 01-jul-2011
-- Description:	Verifica la existencia de Cajeros
-- =============================================
CREATE FUNCTION [Sales].[fxCajerosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCajero FROM Sales.Cajeros WHERE IdCajero=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


