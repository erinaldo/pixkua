CREATE FUNCTION [dbo].[fxDocumentIdTipo](@IdDocument AS varchar(18))
RETURNS CHAR(3)
BEGIN
	DECLARE @IdTipo as CHAR(3)

	IF LEN(rTRIM(lTRIM(@IdDocument))) < 18 
		SET @IdTipo = ''
	ELSE
	BEGIN
		SET @IdDocument = LTRIM(RTRIM(@IdDocument))
		SET @IdTipo = SUBSTRING(@IdDocument,1,3) 
	END 

	RETURN @IdTipo
END


