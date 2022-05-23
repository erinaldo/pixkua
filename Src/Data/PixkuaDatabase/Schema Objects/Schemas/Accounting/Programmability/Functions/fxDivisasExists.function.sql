-- =============================================
-- Author: RCO
-- Create date: 10-sep-2010
-- Description:	Verifica la existencia de Divisas
-- =============================================
CREATE FUNCTION [Accounting].[fxDivisasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdDivisa FROM Accounting.Divisas WHERE IdDivisa=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


