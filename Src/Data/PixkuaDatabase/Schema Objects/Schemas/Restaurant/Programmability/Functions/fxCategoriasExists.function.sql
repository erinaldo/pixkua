-- =============================================
-- Author: alex Lopez
-- Create date: 18-ene-2011
-- Description:	Verifica la existencia de Categorias
-- =============================================
CREATE FUNCTION [Restaurant].[fxCategoriasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCategoria FROM Restaurant.Categorias WHERE IdCategoria=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


