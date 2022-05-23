CREATE PROCEDURE  [Purchasing].[DepartamentosCategoriasDEL]
@IdDepartamento as int out,
@IdCategoriaPresupuestal AS int
AS
	DELETE  Purchasing.DepartamentosCategorias WHERE IdDepartamento=@IdDepartamento AND IdCategoriaPresupuestal=@IdCategoriaPresupuestal


