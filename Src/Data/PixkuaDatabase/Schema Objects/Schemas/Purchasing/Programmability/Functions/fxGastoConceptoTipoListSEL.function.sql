CREATE FUNCTION [Purchasing].[fxGastoConceptoTipoListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT CT.IdGastoConceptoTipo,CT.Nombre,CT.IdCuenta,IsNull(C.Codigo,'') As Cuenta,IsNull(C.Nombre,'') As Concepto
			FROM Purchasing.GastosConceptosTipos CT
			LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=CT.IdCuenta
			WHERE CT.IdEmpresa=@IdEmpresa AND CT.IdStatus=1
)


