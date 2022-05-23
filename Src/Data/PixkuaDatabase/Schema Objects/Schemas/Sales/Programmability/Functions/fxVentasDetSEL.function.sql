-- =============================================
-- Author: RCO
-- Create date: 07-sep-2010
-- Description:	Obtiene la información del VentasDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure VentasDetUPD
-- =============================================
CREATE FUNCTION [Sales].[fxVentasDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN 
	(
	SELECT D.IdVentaDet, D.IdVentaTit, D.Fecha, D.IdArticuloStock, D.IdServicio, D.Codigo, D.Descripcion, D.Cantidad, 
		D.IdUnidadMedida, D.PrecioUnitario, D.IdEstCom, D.IdPromocion, D.PorcDescuento1, 
		D.PorcDescuento2, D.PorcDescuento3, D.PorcDescuento4, D.PorcDescuento5, D.MontoDesc1, 
		D.MontoDesc2, D.MontoDesc3, D.MontoDesc4, D.MontoDesc5, D.IdImpuesto1, D.IdImpuesto2, D.IdImpuesto3, 
		D.IdImpuesto4, D.IdImpuesto5, D.PorcImpTras1, D.PorcImpTras2, D.PorcImpTras3, D.PorcImpTras4, D.PorcImpTras5,
		D.MontoImpTras1, D.MontoImpTras2, D.MontoImpTras3, D.MontoImpTras4, D.MontoImpTras5, D.PorcImpRet1, 
		D.PorcImpRet2, D.PorcImpRet3, D.PorcImpRet4, D.PorcImpRet5, D.MontoImpRet1, D.MontoImpRet2, D.MontoImpRet3, 
		D.MontoImpRet4, D.MontoImpRet5, D.Flete, A.Codigo AS CodigoArticulo, A.Nombre AS NombreArticulo,
		S.Codigo AS CodigoServicio, S.Nombre AS NombreServicio, UM.Nombre AS UnidadMedida
	FROM Sales.VentasDet D LEFT JOIN Sales.Servicios S
		ON D.IdServicio=S.IdServicio
	LEFT JOIN Inventory.ArticulosStock A
		ON D.IdArticuloStock=A.IdArticuloStock
	LEFT JOIN Inventory.UnidadesMedida UM
		ON A.IdUnidadMedida=UM.IdUnidadMedida
	WHERE D.IdVentaTit=@ID and D.Fecha=Documents.fxDocumentDate(@ID)
	)


