-- =============================================
-- Author: alex Lopez
-- Create date: 18-ene-2011
-- Description:	Elimina el Categorias especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[CategoriasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Restaurant.Categorias SET IdStatus=0 WHERE IdCategoria=@ID


