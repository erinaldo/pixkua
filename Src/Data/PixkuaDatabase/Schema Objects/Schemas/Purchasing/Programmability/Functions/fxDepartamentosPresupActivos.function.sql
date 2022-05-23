CREATE FUNCTION [Purchasing].[fxDepartamentosPresupActivos](@IdDepartamento as int)
RETURNS TABLE
AS
	RETURN(	SELECT P.IdPresupuesto,Per.Nombre
			FROM Purchasing.Presupuestos P
			INNER JOIN Purchasing.Periodos Per on Per.IdPeriodo=P.IdPeriodo
			WHERE P.IdDepartamento=@IdDepartamento
)


