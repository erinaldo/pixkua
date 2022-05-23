-- =============================================
-- Author: RCO
-- Create date: 27-oct-2010
-- Description:	Elimina el ServidoresSMTP especificado.
-- =============================================
CREATE PROCEDURE [dbo].[ServidoresSMTPDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.ServidoresSMTP WHERE IdServidorSMTP=@ID


