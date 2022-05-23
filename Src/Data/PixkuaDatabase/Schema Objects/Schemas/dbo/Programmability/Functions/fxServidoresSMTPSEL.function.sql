-- =============================================
-- Author: RCO
-- Create date: 27-oct-2010
-- Description:	Obtiene la información del ServidoresSMTP especificado.
-- =============================================
CREATE FUNCTION [dbo].[fxServidoresSMTPSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM dbo.ServidoresSMTP WHERE IdServidorSMTP=@ID)


