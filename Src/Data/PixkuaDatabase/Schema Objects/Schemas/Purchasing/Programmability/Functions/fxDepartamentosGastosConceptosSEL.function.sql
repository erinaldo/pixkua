CREATE FUNCTION [Purchasing].[fxDepartamentosGastosConceptosSEL](@IdDepartamento as int)
RETURNS TABLE 
AS
RETURN(	SELECT DC.IdGastoConcepto,C.IdGastoConceptoTipo, C.Nombre AS Concepto,CTA.Codigo As Cuenta,CTA.Nombre AS Descripcion,CP.Nombre AS CategoriaPresupuestal,CT.Nombre AS ConceptoTipo,C.IdCategoriaPresupuestal
		FROM Purchasing.DepartamentosGastosConceptos DC
		INNER JOIN Purchasing.GastosConceptos C ON C.IdGastoConcepto=DC.IdGastoConcepto
		INNER JOIN Purchasing.GastosConceptosTipos CT ON CT.IdGastoConceptoTipo=C.IdGastoConceptoTipo
		LEFT  JOIN Accounting.Cuentas AS CTA ON CTA.IdCuenta=c.IdCuenta
		LEFT  JOIN Purchasing.CategoriasPresupuestales AS CP ON CP.IdCategoriaPresupuestal=C.IdCategoriaPresupuestal
		WHERE DC.IdDepartamento=@IdDepartamento
)


