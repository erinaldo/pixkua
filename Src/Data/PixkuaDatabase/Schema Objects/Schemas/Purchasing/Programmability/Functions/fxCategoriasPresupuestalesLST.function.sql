-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Obtiene una lista de búsqueda de CategoriasPresupuestales
-- =============================================
CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdCategoriaPresupuestal,C.Nombre,CT.Codigo As Cuenta,CT.Nombre as Concepto,
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.CategoriasPresupuestales C
	LEFT JOIN Accounting.Cuentas CT ON CT.IdCuenta=C.IdCuenta AND C.IdCuenta>0
	WHERE C.IdEmpresa= (SELECT IdEmpresa FROM dbo.Sucursales  WHERE IdSucursal=@IdSucursal)
	)


