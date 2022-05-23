-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 05-Ene-2006
-- Description:	Verifica la existencia de la política una seguridad.
-- =============================================
CREATE FUNCTION [dbo].[fxPoliticasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPolitica FROM dbo.Politicas WHERE IdPolitica=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


