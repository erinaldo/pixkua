-- =============================================
-- Author: RCO
-- Create date: 07-sep-2010
-- Description:	Elimina el servicio especificado de la venta.
-- =============================================
CREATE PROCEDURE [Sales].[VentasServiciosDEL]
	@IdVentaTit AS char(18),
	@IdServicio as int,
	@IdVentaDet as int
AS
	SET NOCOUNT ON
	
	DELETE Sales.VentasDet 
	WHERE IdVentaTit=@IdVentaTit and Fecha=Documents.fxDocumentDate(@IdVentaTit)
		AND IdArticuloStock=0 and IdServicio=@IdServicio and IdVentaDet=@IdVentaDet


