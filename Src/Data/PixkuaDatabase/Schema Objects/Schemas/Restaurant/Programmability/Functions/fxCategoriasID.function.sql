-- =============================================
-- Author: alex Lopez
-- ALTER  date: 18-ene-2011
-- Description:	Obtiene el ID de Categorias en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Restaurant].[fxCategoriasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCategoria
	FROM Restaurant.Categorias
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


