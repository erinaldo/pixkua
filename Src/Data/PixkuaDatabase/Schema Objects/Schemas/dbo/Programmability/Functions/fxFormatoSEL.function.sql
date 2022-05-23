CREATE FUNCTION [dbo].[fxFormatoSEL](@IdFormato as int)
RETURNS XML
AS
BEGIN
	DECLARE @Formato as XML
	
	SELECT @Formato=Formato 
	FROM dbo.Formatos 
	WHERE IdFormato=@IdFormato
	
	RETURN IsNull(@Formato, '')
END


