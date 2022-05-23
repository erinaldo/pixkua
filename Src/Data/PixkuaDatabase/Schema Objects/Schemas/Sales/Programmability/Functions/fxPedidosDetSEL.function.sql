-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene la información del PedidosDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure PedidosDetUPD
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT IdPedidoDet, IdPedidoTit, Fecha, IdArticuloStock, IdServicio, Codigo, Descripcion, Cantidad, Saldo, IdUnidadMedida, PrecioUnitario, IdPromocion, PorcComision, MontoComision, PorcDescuento1, PorcDescuento2, PorcDescuento3, PorcDescuento4, PorcDescuento5, MontoDesc1, MontoDesc2, MontoDesc3, MontoDesc4, MontoDesc5, IdImpuesto1, IdImpuesto2, IdImpuesto3, IdImpuesto4, IdImpuesto5, PorcImpTras1, PorcImpTras2, PorcImpTras3, PorcImpTras4, PorcImpTras5, MontoImpTras1, MontoImpTras2, MontoImpTras3, MontoImpTras4, MontoImpTras5, PorcImpRet1, PorcImpRet2, PorcImpRet3, PorcImpRet4, PorcImpRet5, MontoImpRet1, MontoImpRet2, MontoImpRet3, MontoImpRet4, MontoImpRet5, Flete 
	FROM Sales.PedidosDet 
	WHERE IdPedidoTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
	)


