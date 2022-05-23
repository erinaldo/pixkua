-- =============================================
-- Author: alexLopez
-- Create date: 15-oct-2010
-- Description:	Elimina el ContabilizacionDocumentosTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[ContabilizacionDocumentosTitDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Accounting.ContabilizacionDocumentosTit SET IdStatus=0 WHERE IdContabilizacionDocumentoTit=@ID


