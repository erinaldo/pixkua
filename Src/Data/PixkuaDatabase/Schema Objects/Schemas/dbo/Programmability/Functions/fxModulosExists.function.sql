-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-Dic-2005
-- Description:	Verifica la existencia de un módulo con el id especificado
-- =============================================
CREATE FUNCTION [dbo].[fxModulosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdModulo FROM dbo.Modulos WHERE IdModulo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


