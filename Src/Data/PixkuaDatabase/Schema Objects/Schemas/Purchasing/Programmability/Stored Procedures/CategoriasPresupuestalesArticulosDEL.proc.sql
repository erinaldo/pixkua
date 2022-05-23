CREATE PROCEDURE [Purchasing].[CategoriasPresupuestalesArticulosDEL]
@IdCategoriaPresupuestal as int,
@IdArticuloStock as int
AS
	DELETE Purchasing.CategoriasPresupuestalesArticulos WHERe @IdCategoriaPresupuestal=@IdCategoriaPresupuestal AND @IdArticuloStock=@IdArticuloStock


