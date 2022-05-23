CREATE FUNCTION [dbo].[fxServidoresSMTPCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdServidorSMTP, Codigo, Nombre
	FROM dbo.ServidoresSMTP
	WHERE IdStatus=1
		)


