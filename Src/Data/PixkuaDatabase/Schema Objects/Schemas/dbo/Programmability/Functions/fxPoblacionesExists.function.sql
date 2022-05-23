-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: <<FECHA>>
-- Description:	Verifica la existencia de <<>>
-- =============================================
CREATE FUNCTION [dbo].[fxPoblacionesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPoblacion FROM dbo.Poblaciones WHERE IdPoblacion=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


