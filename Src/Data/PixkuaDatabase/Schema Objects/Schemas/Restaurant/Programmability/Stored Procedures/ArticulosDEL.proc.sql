-- =============================================
-- Author: alez Lopez
-- Create date: 19-ene-2011
-- Description:	Elimina el Articulos especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[ArticulosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Restaurant.Articulos SET IdStatus=0 WHERE IdArticulo=@ID


