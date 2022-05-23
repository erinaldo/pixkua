-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Elimina el OrdenesTit especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[OrdenesTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.OrdenesTit WHERE IdOrdenTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


