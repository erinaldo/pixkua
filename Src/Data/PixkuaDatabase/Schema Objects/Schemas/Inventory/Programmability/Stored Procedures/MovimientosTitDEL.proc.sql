-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Elimina el MovimientosTit especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[MovimientosTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
		
	DELETE Inventory.MovimientosTit 
	WHERE IdMovimientoTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


