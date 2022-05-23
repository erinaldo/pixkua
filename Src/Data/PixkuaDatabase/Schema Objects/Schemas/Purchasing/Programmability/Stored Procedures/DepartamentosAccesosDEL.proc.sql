CREATE PROCEDURE [Purchasing].[DepartamentosAccesosDEL]
@IdDepartamento as int,
@IdUsuario as int
AS
	DELETE Purchasing.DepartamentosAccesos WHERe IdDepartamento=@IdDepartamento AND IdUsuario=@IdUsuario


