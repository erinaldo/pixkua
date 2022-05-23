CREATE PROCEDURE [Purchasing].[CategoriasPresupuestalesServiciosDEL]
@IdCategoriaPresupuestal as int,
@IdServicio as int
AS
	DELETE Purchasing.CategoriasPresupuestalesServicios WHERe @IdCategoriaPresupuestal=@IdCategoriaPresupuestal AND @IdServicio=@IdServicio


