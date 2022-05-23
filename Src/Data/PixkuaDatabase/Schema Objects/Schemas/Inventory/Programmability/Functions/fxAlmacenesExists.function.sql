-- =============================================
-- Author: RCO
-- Create date: 27-sep-2010
-- Description:	Verifica la existencia de Almacenes
-- =============================================
CREATE FUNCTION [Inventory].[fxAlmacenesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdAlmacen FROM Inventory.Almacenes WHERE IdAlmacen=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


