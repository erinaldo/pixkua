-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Obtiene la información del ComandaDet especificado.
-- Este Stored debe recuperar exactamente los mismos parametros que contiene el Stored Procedure ComandaDetUPD
-- =============================================
CREATE FUNCTION [Restaurant].[fxComandaDetSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS @Return TABLE(  IdCentroProduccion int,IdArticulo int,IdArticuloStock int,Cantidad decimal(19,4),Entregado decimal(19,4),Observaciones varchar(128),Articulo varchar(128),
						PrecioUnitario	decimal(19,4),IdImpuesto1	int,IdImpuesto2	int,IdImpuesto3	int,
						PorImpto1	decimal(19,4),PorImpto2	decimal(19,4),PorImpto3	decimal(19,4),PrecioNeto decimal(19,4))
AS
BEGIN
	INSERT INTO @Return	
		SELECT D.IdCentroProduccion, D.IdArticulo, A.IdArticuloStock, Cantidad,Entregado, D.Observaciones,AX.Nombre AS Articulo,PrecioUnitario,
		D.IdImpuesto1,D.IdImpuesto2,D.IdImpuesto3,D.PorcImpto1,D.PorcImpto2,D.PorcImpto3, PrecioUnitario
		FROM Restaurant.ComandaDet D
		INNER JOIN Restaurant.Articulos A ON A.IdArticulo=D.IdArticulo		
		INNER JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=A.IdArticuloStock
		INNER JOIN Restaurant.ComandaTit CT ON Ct.IdComandaTit=D.IdComandaTit AND CT.Fecha=D.Fecha
		WHERE D.IdComandaTit=@ID and D.Fecha = Documents.fxDocumentDate(@Id)
	
	UPDATE @Return SET PrecioNeto = PrecioNeto+round(PrecioNeto * IsNull(PorImpto1,0), 2)
	UPDATE @Return SET PrecioNeto = PrecioNeto+round(PrecioNeto * IsNull(PorImpto2,0), 2)
	UPDATE @Return SET PrecioNeto = PrecioNeto+round(PrecioNeto * IsNull(PorImpto3,0), 2)

	
	RETURN 
	
END


