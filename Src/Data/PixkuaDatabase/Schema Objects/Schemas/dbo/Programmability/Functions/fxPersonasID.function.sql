-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Mar-2005
-- Description:	Obtiene el ID de Personas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxPersonasID] 
	(@Codigo AS varchar(16),@IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdPersona
	FROM Personas
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


