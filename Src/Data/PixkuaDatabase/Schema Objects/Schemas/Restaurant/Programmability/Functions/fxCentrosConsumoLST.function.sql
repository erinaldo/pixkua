-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Obtiene una lista de búsqueda de CentrosConsumo
-- =============================================
CREATE FUNCTION [Restaurant].[fxCentrosConsumoLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdCentroConsumo, CC.Nombre,C.Codigo,
		CASE CC.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Restaurant.CentrosConsumo CC
	LEFT JOIN Accounting.Cuentas C ON C.IdCuenta=CC.IdCuenta
	WHERE CC.IdSucursal=@IdSucursal
	)


