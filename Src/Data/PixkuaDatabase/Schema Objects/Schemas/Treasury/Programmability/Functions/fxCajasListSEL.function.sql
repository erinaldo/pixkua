CREATE FUNCTION [Treasury].[fxCajasListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT C.IdCaja,C.Nombre,IsNull(Ct.Codigo,'') As Cuenta,IsNull(Ct.Nombre,'') As Concepto
			FROM Treasury.Cajas C
			LEFT JOIN Accounting.Cuentas Ct ON Ct.IdCuenta=C.IdCuenta
			WHERE C.IdEmpresa=@IdEmpresa AND C.IdStatus=1
)


