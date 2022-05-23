-- =============================================
-- Author: Victor Moreno
-- Create date: 01-dic-2016
-- Description:	Verifica la existencia de OrdenesTrabajo
-- =============================================
CREATE FUNCTION Production.fxOrdenesTrabajoExists(@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdOrdenTrabajo FROM Production.OrdenesTrabajo WHERE IdOrdenTrabajo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END
