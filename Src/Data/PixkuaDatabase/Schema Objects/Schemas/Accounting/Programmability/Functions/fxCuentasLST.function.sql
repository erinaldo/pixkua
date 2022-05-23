-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Obtiene una lista de búsqueda de Cuentas
-- =============================================
CREATE FUNCTION [Accounting].[fxCuentasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdCuenta,C.Codigo as Cuenta, C.Nombre as Concepto, CuentaTipo,(CASE WHEN Naturaleza='A' THEN 'Acreedor' ELSE 'Deudor' END) AS Naturaleza
	FROM Accounting.Cuentas C
	INNER JOIN Accounting.CuentasTipos T ON T.IdCuentaTipo=C.IdCuentaTipo
	WHERE C.IdSucursal=@IdSucursal
	)


