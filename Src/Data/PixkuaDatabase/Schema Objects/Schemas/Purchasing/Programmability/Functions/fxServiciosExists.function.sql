-- =============================================
-- Author: RCO
-- Create date: 02-nov-2011
-- Description:	Verifica la existencia de Servicios
-- =============================================
CREATE FUNCTION [Purchasing].[fxServiciosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdServicio FROM Purchasing.Servicios WHERE IdServicio=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


