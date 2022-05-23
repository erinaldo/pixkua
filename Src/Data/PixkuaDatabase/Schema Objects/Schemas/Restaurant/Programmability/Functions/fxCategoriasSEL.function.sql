-- =============================================
-- Author: alex Lopez
-- Create date: 18-ene-2011
-- Description:	Obtiene la información del Categorias especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxCategoriasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Restaurant.Categorias WHERE IdCategoria=@ID)


