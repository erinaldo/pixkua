-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Verifica la existencia de DevolucionesCausas
-- =============================================
CREATE FUNCTION [Sales].[fxDevolucionesCausasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdDevolucionCausa FROM Sales.DevolucionesCausas WHERE IdDevolucionCausa=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


