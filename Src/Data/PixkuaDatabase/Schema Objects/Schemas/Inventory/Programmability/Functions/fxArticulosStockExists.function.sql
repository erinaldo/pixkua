-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Verifica la existencia de ArticulosStock
-- =============================================
CREATE FUNCTION [Inventory].[fxArticulosStockExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdArticuloStock FROM Inventory.ArticulosStock WHERE IdArticuloStock=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


