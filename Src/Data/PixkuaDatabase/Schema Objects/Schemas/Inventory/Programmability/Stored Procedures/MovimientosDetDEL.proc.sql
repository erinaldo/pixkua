-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Elimina el MovimientosDet especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[MovimientosDetDEL]
	@Id AS char(18),
	@IdArticuloStock as int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.MovimientosDet 
	WHERE IdMovimientoTit=@Id  AND Fecha=Documents.fxDocumentDate(@Id) AND IdArticuloStock=@IdArticuloStock


