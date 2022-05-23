-- =============================================
-- Author: Victor Moreno
-- Create date: 07-nov-2016
-- Description:	Verifica la existencia de IncidenciasTipos
-- =============================================
CREATE FUNCTION Production.fxIncidenciasTiposExists(@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdIncidenciaTipo FROM Production.IncidenciasTipos WHERE IdIncidenciaTipo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END
