-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Elimina el NotasTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[NotasTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Accounting.NotasTit WHERE IdNotaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


