-- =============================================
-- Author: alez Lopez
-- Create date: 01-nov-2011
-- Description:	Verifica la existencia de Periodos
-- =============================================
CREATE FUNCTION [Purchasing].[fxPeriodosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPeriodo FROM Purchasing.Periodos WHERE IdPeriodo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


