CREATE PROCEDURE [Restaurant].[CategoriasArticulosUPD]
@IdCategoria as int,
@IdArticulo as int
AS
	UPDATE Restaurant.Articulos SET IdCategoria=@IdCategoria WHERE IdArticulo=@IdArticulo


