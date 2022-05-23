-- =============================================
-- Author: RCO
-- Create date: 26-sep-2010
-- Description:	Verifica la existencia de Areas
-- =============================================
CREATE FUNCTION [Inventory].[fxAreasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdArea FROM Inventory.Areas WHERE IdArea=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


