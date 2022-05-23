CREATE FUNCTION [Documents].[fxDocumentSite](@IdDocumento AS char(18))
RETURNS int
AS
BEGIN
	DECLARE @IdSucursal AS int
	-->Obtener código de la sucursal
	SELECT @IdSucursal= Cast(Substring(@IdDocumento, 4, 3) AS int)

	RETURN @IdSucursal
END


