CREATE FUNCTION [Treasury].[fxBancosChequerasSEL](@IdBanco int)
RETURNS TABLE
AS
RETURN(
		SELECT IdChequera,C.Nombre,Cuenta AS CuentaBancaria,C.IdCaja,C.IdCuenta,Ct.Codigo as Cuenta,Ct.Nombre as Concepto
		FROM Treasury.Chequeras C
		LEFT JOIN Accounting.Cuentas AS Ct ON Ct.IdCuenta=C.IdCuenta
		WHERE C.IdBanco=@IdBanco AND C.IdStatus=1
)


