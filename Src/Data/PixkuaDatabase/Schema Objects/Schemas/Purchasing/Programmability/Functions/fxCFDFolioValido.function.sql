CREATE FUNCTION [Purchasing].[fxCFDFolioValido](@RFC as char(13), @NumAprobacion as int, @AnioAprobacion as int, @Serie as char(10), @Folio as int)
RETURNS bit
AS
BEGIN
	DECLARE @Result as bit

	IF EXISTS(SELECT RFC FROM Purchasing.CFDFolios WHERE RFC=@RFC AND NumAprobacion=@NumAprobacion AND AnioAprobacion=@AnioAprobacion AND Serie=@Serie AND FolioInicial <= @Folio AND FolioFinal >= @Folio)
		SET @Result=1
	ELSE
		SET @Result=0
	
	RETURN @Result
	
END


