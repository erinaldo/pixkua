CREATE FUNCTION [Purchasing].[fxPresupuestosCBO](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT P.IdPresupuesto,Per.Nombre + '-' + Drh.Nombre AS Nombre,P.IdEmpresa,D.AdmonPresupuesto
			FROM Purchasing.Presupuestos P
			INNER JOIN Purchasing.Periodos Per on Per.IdPeriodo=P.IdPeriodo
			INNER JOIN RH.Departamentos AS Drh ON Drh.IdDepartamento=P.IdDepartamento
			INNER JOIN Purchasing.Departamentos D ON D.IdDepartamento=P.IdDepartamento
			WHERE P.IdStatus>0 AND P.Estatus='A' AND P.IdEmpresa=@IdEmpresa
	)


