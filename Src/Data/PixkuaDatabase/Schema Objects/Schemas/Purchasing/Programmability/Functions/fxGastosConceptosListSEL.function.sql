CREATE FUNCTION [Purchasing].[fxGastosConceptosListSEL](@IdGastoConceptoTipo as int)
RETURNS TABLE
AS
RETURN(
		SELECT IdGastoConcepto,C.Nombre AS Concepto,C.IdCuenta,Cta.Codigo,Cta.Nombre AS Descripcion,C.IdCategoriaPresupuestal
		FROM Purchasing.GastosConceptos C 
		LEFT  JOIN Accounting.Cuentas Cta ON Cta.IdCuenta=C.IdCuenta
		LEFT  JOIN Purchasing.CategoriasPresupuestales CP ON CP.IdCategoriaPresupuestal=C.IdCategoriaPresupuestal
		WHERE C.IdGastoConceptoTipo=@IdGastoConceptoTipo
)


