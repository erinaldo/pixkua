-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Obtiene una lista de búsqueda de GastosConceptosTipos
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosConceptosTiposLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdGastoConceptoTipo,C.Nombre, Cta.Codigo as Cuenta,Cta.Nombre as Descripcion,
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.GastosConceptosTipos C
	LEFT JOIN Accounting.Cuentas Cta on Cta.IdCuenta=C.IdCuenta
	WHERE C.IdSucursal=@IdSucursal
	)


