CREATE FUNCTION [Documents].[fxDocumentDate](@DocumentId AS CHAR(18))
RETURNS DATETIME
BEGIN
	DECLARE @Fecha as DATETIME
	IF LEN(RTRIM(LTRIM(@DocumentId))) < 18 
		SET @Fecha = null
	ELSE
	BEGIN
		SET @DocumentId =  LTRIM(RTRIM(@DocumentId))
		SET @Fecha = '01-' + '01-' + SUBSTRING(@DocumentId,7,4)
	
		SET @Fecha= DATEADD(dd, cast(SUBSTRING(@DocumentId,11,3)as int)-1, @Fecha )
	END    	
			
	RETURN @Fecha
	
END


