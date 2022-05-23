-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Verifica la existencia de ZonasVenta
-- =============================================
CREATE FUNCTION [Sales].[fxZonasVentaExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdZonaVenta FROM Sales.ZonasVenta WHERE IdZonaVenta=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


