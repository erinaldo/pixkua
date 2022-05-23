-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Elimina el detalle de la orden especificada.
-- =============================================
CREATE PROCEDURE [Purchasing].[OrdenesDetDEL]
	@IdOrdenTit AS char(18),
	@IdArticuloStock as int,
	@IdServicio as int
AS
	SET NOCOUNT ON
	
	DECLARE @Fecha as datetime
	SET @Fecha=Documents.fxDocumentDate(@IdOrdenTit)
	
	DELETE Purchasing.OrdenesDet 
	WHERE IdOrdenTit=@IdOrdenTit AND Fecha=@Fecha AND IdArticuloStock=@IdArticuloStock AND IdServicio=@IdServicio


