CREATE FUNCTION [Purchasing].[CFDExists](@IdProveedor as int, @Serie as char(10), @Folio as int)
RETURNS bit
AS
BEGIN
	DECLARE @Result as bit

	IF EXISTS(SELECT Folio FROM Purchasing.CFD WHERE IdProveedor=@IdProveedor AND Serie=@Serie AND Folio=@Folio)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result
END


