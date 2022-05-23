-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Mar-2005
-- Description:	Obtiene el ID de la política en base a su código de usuario.
-- =============================================
CREATE FUNCTION [dbo].[fxPoliticasID]
	(
		@Codigo AS varchar(10),@IdSucursal as int
	)
RETURNS int
AS
BEGIN
	DECLARE @ID AS int
	
	SELECT @ID=IdPolitica
	FROM Politicas
	WHERE IdPolitica=Cast(@Codigo AS int)

	RETURN IsNull(@ID, 0)
END


