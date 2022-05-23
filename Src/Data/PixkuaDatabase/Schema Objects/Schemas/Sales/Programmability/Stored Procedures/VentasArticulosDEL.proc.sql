-- =============================================
-- Author: RCO
-- Create date: 07-sep-2010
-- Description:	Elimina el artículo especificado de la venta.
-- =============================================
CREATE PROCEDURE [Sales].[VentasArticulosDEL]
	@IdVentaTit AS char(18),
	@IdArticuloStock as int	
AS
	SET NOCOUNT ON
	
	DELETE Sales.VentasDet 
	WHERE IdVentaTit=@IdVentaTit and Fecha=Documents.fxDocumentDate(@IdVentaTit)
		and IdArticuloStock=@IdArticuloStock and IdServicio=0


