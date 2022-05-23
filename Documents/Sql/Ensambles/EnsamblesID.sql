-- =============================================
-- Author: Victor Moreno
-- ALTER  date: 16-nov-2016
-- Description:	Obtiene el ID de Ensambles en base a su código de usuario.
-- =============================================

CREATE FUNCTION Production.fxEnsamblesID 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdEnsamble
	FROM Production.Ensambles
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END