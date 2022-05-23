-- =============================================
-- Author: Victor Moreno
-- Create date: 07-nov-2016
-- Description:	Elimina el IncidenciasTipos especificado.
-- =============================================
CREATE PROCEDURE Production.IncidenciasTiposDEL
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Production.IncidenciasTipos WHERE IdIncidenciaTipo=@ID