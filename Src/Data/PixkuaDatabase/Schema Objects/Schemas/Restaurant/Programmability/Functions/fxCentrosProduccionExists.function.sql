-- =============================================
-- Author: alez lopez
-- Create date: 19-ene-2011
-- Description:	Verifica la existencia de CentrosProduccion
-- =============================================
CREATE FUNCTION [Restaurant].[fxCentrosProduccionExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCentroProduccion FROM Restaurant.CentrosProduccion WHERE IdCentroProduccion=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


