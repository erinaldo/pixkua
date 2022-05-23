-- =============================================
-- Author: Victor Moreno
-- Create date: 16-nov-2016
-- Description:	Verifica la existencia de Ensambles
-- =============================================
CREATE FUNCTION Production.fxEnsamblesExists(@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdEnsamble FROM Production.Ensambles WHERE IdEnsamble=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END
