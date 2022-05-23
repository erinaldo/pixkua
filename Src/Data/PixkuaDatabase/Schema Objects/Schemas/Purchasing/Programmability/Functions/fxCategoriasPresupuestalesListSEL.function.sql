CREATE FUNCTION [Purchasing].[fxCategoriasPresupuestalesListSEL](@IdEmpresa as int)
RETURNS TABLE
AS
	RETURN(	SELECT C.IdCategoriaPresupuestal, C.Nombre, C.IdCuenta, 
				IsNull(Ct.Codigo,'') As Cuenta, IsNull(Ct.Nombre,'') As Concepto,''AS CategoriaFlujo
			FROM Purchasing.CategoriasPresupuestales C
			LEFT JOIN Accounting.Cuentas Ct ON Ct.IdCuenta=C.IdCuenta
			WHERE C.IdEmpresa=@IdEmpresa AND C.IdStatus=1
)


