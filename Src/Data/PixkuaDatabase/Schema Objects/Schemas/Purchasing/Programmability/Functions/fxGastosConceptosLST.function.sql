-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Obtiene una lista de búsqueda de GastosConceptos
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosConceptosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdGastoConcepto,C.Nombre AS Concepto,Cta.Codigo AS Cuenta,Cta.Nombre AS Descripcion,CP.Nombre AS [Categoria Presupuestal],
		CASE C.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.GastosConceptos C
	INNER JOIN Purchasing.GastosConceptosTipos T ON T.IdGastoConceptoTipo=C.IdGastoConceptoTipo
	LEFT JOIN Accounting.Cuentas Cta on Cta.IdCuenta=C.IdCuenta
	LEFT JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=C.IdCategoriaPresupuestal
	WHERE C.IdSucursal=@IdSucursal
	)


