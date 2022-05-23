-- =============================================
-- Author: alez Lopez
-- Create date: 19-ene-2011
-- Description:	Verifica la existencia de Articulos
-- =============================================
CREATE FUNCTION [Restaurant].[fxArticulosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdArticulo FROM Restaurant.Articulos WHERE IdArticulo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


