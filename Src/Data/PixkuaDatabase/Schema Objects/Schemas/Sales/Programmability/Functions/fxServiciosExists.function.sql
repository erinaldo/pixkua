-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Verifica la existencia de Servicios
-- =============================================
CREATE FUNCTION [Sales].[fxServiciosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdServicio FROM Sales.Servicios WHERE IdServicio=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


