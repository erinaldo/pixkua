-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Verifica la existencia del usuario especificado.
-- =============================================

CREATE  FUNCTION [dbo].[fxUsuariosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdUsuario FROM dbo.Usuarios WHERE IdUsuario=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


