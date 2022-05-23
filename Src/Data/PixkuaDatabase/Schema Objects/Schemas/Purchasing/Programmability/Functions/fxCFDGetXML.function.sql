CREATE FUNCTION [Purchasing].[fxCFDGetXML](@IdProveedor as int,@Serie as Char(10),@Folio as int,@UUID char(36))
RETURNS XML
AS
BEGIN	
	DECLARE @XML AS XML
	
	SELECT @XML=Comprobante
	FROM Purchasing.CFD
	WHERE IdProveedor=@IdProveedor AND Serie=@Serie AND Folio=@Folio AND UUID=@UUID
		
	RETURN @XML	
		
END


