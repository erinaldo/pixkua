CREATE PROCEDURE [Restaurant].[CategoriasArticulosDEL]
@IdCategoria as int,
@IdArticulo as int
AS
	UPDATE Restaurant.Articulos SET IdCategoria=0 WHERE IdArticulo=@IdArticulo


