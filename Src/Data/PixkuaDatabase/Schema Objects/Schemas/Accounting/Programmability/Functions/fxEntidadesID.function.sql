-- =============================================
-- Author: alex Lopez
-- ALTER  date: 13-oct-2010
-- Description:	Obtiene el ID de Entidades en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxEntidadesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdEntidad
	FROM Accounting.Entidades
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


