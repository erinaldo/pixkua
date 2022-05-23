-- =============================================
-- Author: Victor Moreno
-- ALTER  date: 10-nov-2016
-- Description:	Obtiene el ID de Incidencias en base a su código de usuario.
-- =============================================

CREATE FUNCTION Production.fxIncidenciasID 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdIncidencia
	FROM Production.Incidencias
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END