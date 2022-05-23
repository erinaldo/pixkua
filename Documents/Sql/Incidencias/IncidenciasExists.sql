-- =============================================
-- Author: Victor Moreno
-- Create date: 10-nov-2016
-- Description:	Verifica la existencia de Incidencias
-- =============================================
CREATE FUNCTION Production.fxIncidenciasExists(@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdIncidencia FROM Production.Incidencias WHERE IdIncidencia=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END
