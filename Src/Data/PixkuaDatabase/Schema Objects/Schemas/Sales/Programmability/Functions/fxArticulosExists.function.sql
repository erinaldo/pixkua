-- =============================================
-- Author: RCO
-- Create date: 14-oct-2010
-- Description:	Verifica la existencia de Articulos
-- =============================================
CREATE FUNCTION [Sales].[fxArticulosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdArticulo FROM Sales.Articulos WHERE IdArticulo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


