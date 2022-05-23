-- =============================================
-- Author: RCO
-- Create date: 01-nov-2011
-- Description:	Verifica la existencia de ZonasCompra
-- =============================================
CREATE FUNCTION [Purchasing].[fxZonasCompraExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdZonaCompra FROM Purchasing.ZonasCompra WHERE IdZonaCompra=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


