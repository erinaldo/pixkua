-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Verifica la existencia de Meseros
-- =============================================
CREATE FUNCTION [Restaurant].[fxMeserosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdMesero FROM Restaurant.Meseros WHERE IdMesero=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


