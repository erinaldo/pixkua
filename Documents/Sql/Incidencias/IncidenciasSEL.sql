-- =============================================
-- Author: Victor Moreno
-- Create date: 10-nov-2016
-- Description:	Obtiene la información del Incidencias especificado.
-- =============================================
CREATE FUNCTION Production.fxIncidenciasSEL(@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Production.Incidencias WHERE IdIncidencia=@ID)