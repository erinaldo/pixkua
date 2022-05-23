-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Elimina el TraspasosDet especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[TraspasosDetDEL]
	@Id AS char(18)
AS
	SET NOCOUNT ON
	
	DELETE Inventory.TraspasosDet 
	WHERE IdTraspasoTit=@Id  and Fecha=Documents.fxDocumentDate(@Id)


