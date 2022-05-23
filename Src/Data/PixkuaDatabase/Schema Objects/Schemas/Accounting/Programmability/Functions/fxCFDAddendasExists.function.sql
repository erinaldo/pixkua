-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Verifica la existencia de CFDAddendas
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDAddendasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCFDAddenda FROM Accounting.CFDAddendas WHERE IdCFDAddenda=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


