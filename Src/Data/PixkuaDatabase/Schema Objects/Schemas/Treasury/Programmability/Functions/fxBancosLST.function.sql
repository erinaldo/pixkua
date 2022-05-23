-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Obtiene una lista de búsqueda de Bancos
-- =============================================
CREATE FUNCTION [Treasury].[fxBancosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT B.IdBanco, B.Nombre,C.Codigo as Cuenta,C.Nombre AS Concepto,
		CASE B.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Treasury.Bancos B
	LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=B.IdCuenta
	WHERE B.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


