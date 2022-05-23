-- =============================================
-- Author: Victor Moreno
-- Create date: 10-nov-2016
-- Description:	Obtiene una lista de búsqueda de Incidencias
-- =============================================
CREATE FUNCTION Production.fxIncidenciasLST(@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdIncidencia
	FROM Production.Incidencias
	WHERE IdSucursal=@IdSucursal)