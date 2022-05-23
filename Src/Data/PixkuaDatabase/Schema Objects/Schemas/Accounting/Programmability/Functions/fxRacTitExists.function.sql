-- =============================================
-- Author: alex Lopez
-- Create date: 08-oct-2010
-- Description:	Verifica la existencia de RacTit
-- =============================================
CREATE FUNCTION [Accounting].[fxRacTitExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRacTit FROM Accounting.RacTit WHERE IdRacTit=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


