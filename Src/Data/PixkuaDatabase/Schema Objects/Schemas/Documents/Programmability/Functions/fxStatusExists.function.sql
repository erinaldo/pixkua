-- =============================================
-- Author: alex Lopez
-- Create date: 14-oct-2010
-- Description:	Verifica la existencia de Status
-- =============================================
CREATE FUNCTION [Documents].[fxStatusExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdStatus FROM Documents.Status WHERE IdStatus=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


