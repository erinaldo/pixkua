CREATE FUNCTION [dbo].[fxRemitentesMailCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdRemitenteMail, Codigo, Nombre
	FROM dbo.RemitentesMail
	WHERE IdEmpresa=@IdEmpresa
		)


