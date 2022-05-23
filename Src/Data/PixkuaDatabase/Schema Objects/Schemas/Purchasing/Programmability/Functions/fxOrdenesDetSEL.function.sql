-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Obtiene la información del OrdenesDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure OrdenesDetUPD
-- =============================================
CREATE FUNCTION [Purchasing].[fxOrdenesDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT IdOrdenDet, IdOrdenTit, Fecha, IdArticuloStock, IdServicio, Observaciones, Cantidad, Recibido, IdUnidadMedida, CostoUnitario, IdPresupuesto, IdCategoriaPresupuestal, IdRequisicion, FechaRequisicion, PorcDescuento1, PorcDescuento2, PorcDescuento3, PorcDescuento4, PorcDescuento5, MontoDesc1, MontoDesc2, MontoDesc3, MontoDesc4, MontoDesc5, IdImpuesto1, IdImpuesto2, IdImpuesto3, IdImpuesto4, IdImpuesto5, PorcImpTras1, PorcImpTras2, PorcImpTras3, PorcImpTras4, PorcImpTras5, MontoImpTras1, MontoImpTras2, MontoImpTras3, MontoImpTras4, MontoImpTras5, IdRetencion1, IdRetencion2, IdRetencion3, IdRetencion4, IdRetencion5, PorcImpRet1, PorcImpRet2, PorcImpRet3, PorcImpRet4, PorcImpRet5, MontoImpRet1, MontoImpRet2, MontoImpRet3, MontoImpRet4, MontoImpRet5, Flete 
	FROM Purchasing.OrdenesDet 
	WHERE IdOrdenTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
	)


