CREATE FUNCTION [Treasury].[fxBancosListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT B.IdBanco,B.Nombre,IsNull(Ct.Codigo,'') As Cuenta,IsNull(Ct.Nombre,'') As Concepto
			FROM Treasury.Bancos B
			LEFT JOIN Accounting.Cuentas Ct ON Ct.IdCuenta=B.IdCuenta
			WHERE B.IdEmpresa=@IdEmpresa AND B.IdStatus=1
)


