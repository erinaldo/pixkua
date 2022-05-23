-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Obtiene la información del NotasDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure NotasDetUPD
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT D.IdNotaConcepto, D.Concepto, D.Monto, D.IdImpuestoTras1, D.IdImpuestoTras2, 
		D.IdImpuestoTras3, D.PorcImpTras1, D.PorcImpTras2, D.PorcImpTras3, D.MontoImpTras1, D.MontoImpTras2, 
		D.MontoImpTras3, D.IdImpuestoRet1, D.IdImpuestoRet2, D.IdImpuestoRet3, D.PorcImpRet1, D.PorcImpRet2, D.PorcImpRet3, 
		D.MontoImpRet1, D.MontoImpRet2, D.MontoImpRet3, NC.Codigo AS CodigoConcepto,
		C.Codigo AS CuentaContable	
	FROM Accounting.NotasDet D JOIN Accounting.NotasConceptos NC
		ON D.IdNotaConcepto=NC.IdNotaConcepto
	JOIN Accounting.Cuentas C
		ON NC.IdCuenta=C.IdCuenta
	WHERE IdNotaTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
	)


