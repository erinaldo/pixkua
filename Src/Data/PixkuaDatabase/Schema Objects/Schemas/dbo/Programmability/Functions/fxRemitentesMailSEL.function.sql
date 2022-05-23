-- =============================================
-- Author: RCO
-- Create date: 24-oct-2010
-- Description:	Obtiene la información del RemitentesMail especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxRemitentesMailSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.RemitentesMail WHERE IdRemitenteMail=@ID)


