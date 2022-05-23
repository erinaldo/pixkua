-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Elimina el ContrarecibosTit especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[ContrarecibosTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Treasury.ContrarecibosTit WHERE IdContrareciboTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


