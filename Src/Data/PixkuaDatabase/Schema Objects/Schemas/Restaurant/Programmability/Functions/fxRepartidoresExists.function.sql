-- =============================================
-- Author: alez Lopez
-- Create date: 08-ago-2011
-- Description:	Verifica la existencia de Repartidores
-- =============================================
CREATE FUNCTION [Restaurant].[fxRepartidoresExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdRepartidor FROM Restaurant.Repartidores WHERE IdRepartidor=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


