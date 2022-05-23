-- =============================================
-- Author: RCO
-- Create date: 20-sep-2010
-- Description:	Verifica la existencia de Paises
-- =============================================
CREATE FUNCTION [dbo].[fxPaisesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPais FROM dbo.Paises WHERE IdPais=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


