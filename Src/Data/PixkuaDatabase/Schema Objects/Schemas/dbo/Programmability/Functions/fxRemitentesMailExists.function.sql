-- =============================================
-- Author: RCO
-- Create date: 24-oct-2010
-- Description:	Verifica la existencia de RemitentesMail
-- =============================================
CREATE FUNCTION [dbo].[fxRemitentesMailExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRemitenteMail FROM dbo.RemitentesMail WHERE IdRemitenteMail=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


