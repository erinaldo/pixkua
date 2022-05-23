-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Verifica la existencia de FormasPago
-- =============================================
CREATE FUNCTION [Sales].[fxFormasPagoExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdFormaPago FROM Sales.FormasPago WHERE IdFormaPago=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


