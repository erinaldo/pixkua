-- =============================================
-- Author: RCO
-- Create date: 24-oct-2010
-- Description:	Elimina el RemitentesMail especificado.
-- =============================================
CREATE PROCEDURE [dbo].[RemitentesMailDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.RemitentesMail WHERE IdRemitenteMail=@ID


