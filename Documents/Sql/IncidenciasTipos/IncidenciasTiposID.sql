-- =============================================
-- Author: Victor Moreno
-- ALTER  date: 07-nov-2016
-- Description:	Obtiene el ID de IncidenciasTipos en base a su código de usuario.
-- =============================================

CREATE FUNCTION Production.fxIncidenciasTiposID 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdIncidenciaTipo
	FROM Production.IncidenciasTipos
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END