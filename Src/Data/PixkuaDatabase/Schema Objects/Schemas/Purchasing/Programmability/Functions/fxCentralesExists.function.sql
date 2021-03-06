-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Verifica la existencia de Centrales
-- =============================================
CREATE FUNCTION [Purchasing].[fxCentralesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCentral FROM Purchasing.Centrales WHERE IdCentral=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


