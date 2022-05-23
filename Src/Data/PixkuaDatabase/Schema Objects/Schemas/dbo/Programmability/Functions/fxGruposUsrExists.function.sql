-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Verifica la existencia de <<>>
-- =============================================
CREATE FUNCTION [dbo].[fxGruposUsrExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdGrupo FROM dbo.GruposUsr WHERE IdGrupo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


