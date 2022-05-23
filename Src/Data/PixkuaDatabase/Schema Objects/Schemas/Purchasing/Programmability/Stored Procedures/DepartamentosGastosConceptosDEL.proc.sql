CREATE PROCEDURE  [Purchasing].[DepartamentosGastosConceptosDEL]
@IdDepartamento as int out,
@IdGastoConcepto AS int
AS
	DELETE  Purchasing.DepartamentosGastosConceptos WHERE IdDepartamento=@IdDepartamento AND IdGastoConcepto=@IdGastoConcepto


