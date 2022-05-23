-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Mar-2005
-- Description:	Obtiene el ID del módulo en base a su código de usuario.
-- =============================================
CREATE FUNCTION [dbo].[fxModulosID]
	(
		@Codigo AS varchar(10),@IdSucursal as int
	)
RETURNS int
AS
BEGIN
	DECLARE @ID AS int
	
	SELECT @ID=IdModulo
	FROM Modulos
	WHERE IdModulo=Cast(@Codigo AS int)

	RETURN IsNull(@ID, 0)
END


