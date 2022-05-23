-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Verifica la existencia de Mesas
-- =============================================
CREATE FUNCTION [Restaurant].[fxMesasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdMesa FROM Restaurant.Mesas WHERE IdMesa=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


