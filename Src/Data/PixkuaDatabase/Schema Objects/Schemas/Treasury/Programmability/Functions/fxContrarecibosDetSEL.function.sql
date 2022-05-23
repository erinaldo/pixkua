-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Obtiene la información del ContrarecibosDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure ContrarecibosDetUPD
-- =============================================
CREATE FUNCTION [Treasury].[fxContrarecibosDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT IdContrareciboDet, IdContrareciboTit, Fecha, CodigoConcepto, DecripcionConcepto, IdCuenta, Monto, IdImpuesto1, IdImpuesto2, IdImpuesto3, IdImpuesto4, IdImpuesto5, PorcImpTras1, PorcImpTras2, PorcImpTras3, PorcImpTras4, PorcImpTras5, MontoImpTras1, MontoImpTras2, MontoImpTras3, MontoImpTras4, MontoImpTras5, IdRetencion1, IdRetencion2, IdRetencion3, IdRetencion4, IdRetencion5, PorcImpRet1, PorcImpRet2, PorcImpRet3, PorcImpRet4, PorcImpRet5, MontoImpRet1, MontoImpRet2, MontoImpRet3, MontoImpRet4, MontoImpRet5 
	FROM Treasury.ContrarecibosDet 
	WHERE IdContrareciboTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
	)


