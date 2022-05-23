-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Elimina el ContrarecibosDet especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[ContrarecibosDetDEL]
	@Id AS char(18)
AS
	SET NOCOUNT ON
	
	DELETE Treasury.ContrarecibosDet 
	WHERE IdContrareciboTit=@Id  and Fecha=Documents.fxDocumentDate(@Id)


