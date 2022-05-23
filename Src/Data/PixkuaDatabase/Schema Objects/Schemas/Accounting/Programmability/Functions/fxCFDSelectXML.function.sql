CREATE FUNCTION [Accounting].[fxCFDSelectXML](@IdCFDSerie as int, @Folio as int)
RETURNS xml
AS
BEGIN
	DECLARE @Comprobante as xml

	SELECT @Comprobante=Comprobante
	FROM Accounting.CFD
	WHERE IdCFDSerie=@IdCFDSerie AND Folio=@Folio
	
	RETURN @Comprobante
END


