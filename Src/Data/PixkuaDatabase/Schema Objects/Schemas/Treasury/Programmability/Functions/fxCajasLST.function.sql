-- =============================================
-- Author: alex Lopez
-- Create date: 30-nov-2011
-- Description:	Obtiene una lista de búsqueda de Cajas
-- =============================================
CREATE FUNCTION [Treasury].[fxCajasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT C.IdCaja,C.Nombre,Ct.Nombre AS Cuenta,Ct.Nombre AS Concepto,
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Treasury.Cajas C
	LEFT JOIN Accounting.Cuentas AS Ct on Ct.IdCuenta=C.IdCuenta
	WHERE C.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


