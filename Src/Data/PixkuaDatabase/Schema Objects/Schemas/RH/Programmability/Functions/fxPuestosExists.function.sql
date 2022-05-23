-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Verifica la existencia de Puestos
-- =============================================
CREATE FUNCTION [RH].[fxPuestosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPuesto FROM RH.Puestos WHERE IdPuesto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


