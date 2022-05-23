-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 10-Mar-2006
-- Description:	Verifica la existencia de <<>>
-- =============================================
CREATE FUNCTION [dbo].[fxCatalogosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCatalogo FROM dbo.Catalogos WHERE IdCatalogo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


