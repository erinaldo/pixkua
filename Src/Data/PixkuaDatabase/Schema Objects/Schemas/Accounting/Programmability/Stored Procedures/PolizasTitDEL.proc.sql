-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Elimina el PolizasTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Accounting.PolizasTit WHERE IdPolizaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


