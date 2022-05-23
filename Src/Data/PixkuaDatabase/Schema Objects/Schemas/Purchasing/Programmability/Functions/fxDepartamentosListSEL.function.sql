CREATE FUNCTION [Purchasing].[fxDepartamentosListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT D.IdDepartamento,D.Nombre,IsNull(Ct.Codigo,'') AS Cuenta,ISNULL(Ct.Nombre,'')AS Concepto,ISNULL(DC.IdCentral,0) AS IdCentral
			FROM RH.Departamentos D
			LEFT JOIN Purchasing.Departamentos DC ON DC.IdDepartamento=D.IdDepartamento
			LEFT JOIN Accounting.Cuentas Ct ON Ct.IdCuenta=DC.IdCuenta
			WHERE D.IdEmpresa=@IdEmpresa AND D.IdStatus=1
)


