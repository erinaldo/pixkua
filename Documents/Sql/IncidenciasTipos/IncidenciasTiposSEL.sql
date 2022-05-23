-- =============================================
-- Author: Victor Moreno
-- Create date: 07-nov-2016
-- Description:	Obtiene la información del IncidenciasTipos especificado.
-- =============================================
CREATE FUNCTION Production.fxIncidenciasTiposSEL(@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Production.IncidenciasTipos WHERE IdIncidenciaTipo=@ID)