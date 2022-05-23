-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Elimina el TraspasosTit especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[TraspasosTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Inventory.TraspasosTit WHERE IdTraspasoTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


