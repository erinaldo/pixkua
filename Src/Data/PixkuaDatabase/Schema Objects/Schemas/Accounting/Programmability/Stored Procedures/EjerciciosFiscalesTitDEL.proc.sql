-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Elimina el EjerciciosFiscalesTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[EjerciciosFiscalesTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Accounting.EjerciciosFiscalesTit WHERE IdEjercicioFiscalTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


