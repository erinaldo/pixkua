-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Obtiene una lista de búsqueda de Mesas
-- =============================================
CREATE FUNCTION [Restaurant].[fxMesasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdMesa,M.Descripcion,C.Codigo AS Cuenta,
		CASE M.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Restaurant.Mesas M
	LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=M.IdCuenta
	WHERE M.IdSucursal=@IdSucursal
	)


