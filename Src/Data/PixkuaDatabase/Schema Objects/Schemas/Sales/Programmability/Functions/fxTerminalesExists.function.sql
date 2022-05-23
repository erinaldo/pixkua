-- =============================================
-- Author: alez Lopez
-- Create date: 31-ago-2011
-- Description:	Verifica la existencia de Terminales
-- =============================================
CREATE FUNCTION [Sales].[fxTerminalesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdTerminal FROM Sales.Terminales WHERE IdTerminal=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


