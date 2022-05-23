CREATE FUNCTION [Documents].[fxDocumentType](@IdDocumento as char(18))
RETURNS int
AS
BEGIN
	DECLARE @IdTipo AS int
	SELECT @IdTipo=Cast(Left(@IdDocumento, 3) AS int)
	RETURN @IdTipo
END


