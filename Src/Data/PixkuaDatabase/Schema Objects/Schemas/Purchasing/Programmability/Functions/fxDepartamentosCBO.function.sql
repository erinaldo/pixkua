CREATE FUNCTION [Purchasing].[fxDepartamentosCBO](@IdEmpresa as int, @IdUsuario as int)
RETURNS TABLE
AS
	RETURN(	
			SELECT A.IdDepartamento, Drh.Nombre, Drh.NamedPath, D.AdmonPresupuesto, C.IdZonaCompra
			FROM Purchasing.DepartamentosAccesos A
			INNER JOIN RH.Departamentos Drh 
				ON Drh.IdDepartamento=A.IdDepartamento
			INNER JOIN Purchasing.Departamentos D 
				ON D.IdDepartamento=A.IdDepartamento
			INNER JOIN Purchasing.Centrales C
				ON D.IdCentral=C.IdCentral
			WHERE IdUsuario=@IdUsuario AND Drh.IdEmpresa=@IdEmpresa
			)


