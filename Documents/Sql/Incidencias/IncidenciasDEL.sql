-- =============================================
-- Author: Victor Moreno
-- Create date: 10-nov-2016
-- Description:	Elimina el Incidencias especificado.
-- =============================================
CREATE PROCEDURE Production.IncidenciasDEL
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Production.Incidencias WHERE IdIncidencia=@ID