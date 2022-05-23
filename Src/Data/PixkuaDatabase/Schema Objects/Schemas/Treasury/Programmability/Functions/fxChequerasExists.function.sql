-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Verifica la existencia de Chequeras
-- =============================================
CREATE FUNCTION [Treasury].[fxChequerasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdChequera FROM Treasury.Chequeras WHERE IdChequera=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


