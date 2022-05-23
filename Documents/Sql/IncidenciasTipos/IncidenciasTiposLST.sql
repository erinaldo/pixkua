-- =============================================
-- Author: Victor Moreno
-- Create date: 07-nov-2016
-- Description:	Obtiene una lista de búsqueda de IncidenciasTipos
-- =============================================
CREATE FUNCTION Production.fxIncidenciasTiposLST(@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdIncidenciaTipo
	FROM Production.IncidenciasTipos
	WHERE IdSucursal=@IdSucursal)