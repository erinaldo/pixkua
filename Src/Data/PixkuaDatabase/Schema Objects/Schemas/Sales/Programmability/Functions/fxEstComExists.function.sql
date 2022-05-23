-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Verifica la existencia de EstCom
-- =============================================
CREATE FUNCTION [Sales].[fxEstComExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdEstCom FROM Sales.EstCom WHERE IdEstCom=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


