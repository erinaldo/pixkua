-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Obtiene la información del GastosConceptos especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosConceptosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT C.*,CT.Nombre AS GastoConceptoTipo,IsNull(Cta.Codigo,'') AS Cuenta,IsNull(Cta.Nombre,'') AS DescrCuenta,IsNull(CP.Nombre,'') As CategoriaPresupuestal
	 FROM Purchasing.GastosConceptos C
	 INNER JOIN Purchasing.GastosConceptosTipos AS CT ON CT.IdGastoConceptoTipo=C.IdGastoConceptoTipo
	 LEFT JOIN Accounting.Cuentas Cta ON Cta.IdCuenta=C.IdCuenta
	 LEFT JOIN Purchasing.CategoriasPresupuestales AS CP ON CP.IdCategoriaPresupuestal=C.IdCategoriaPresupuestal
	 WHERE IdGastoConcepto=@ID)


