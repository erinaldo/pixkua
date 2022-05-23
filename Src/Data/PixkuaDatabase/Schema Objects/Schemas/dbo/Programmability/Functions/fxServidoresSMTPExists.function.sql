-- =============================================
-- Author: RCO
-- Create date: 27-oct-2010
-- Description:	Verifica la existencia de ServidoresSMTP
-- =============================================
CREATE FUNCTION [dbo].[fxServidoresSMTPExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdServidorSMTP FROM dbo.ServidoresSMTP WHERE IdServidorSMTP=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


