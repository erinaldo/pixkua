-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Verifica la existencia de Regiones
-- =============================================
CREATE FUNCTION [Sales].[fxRegionesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRegion FROM Sales.Regiones WHERE IdRegion=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


