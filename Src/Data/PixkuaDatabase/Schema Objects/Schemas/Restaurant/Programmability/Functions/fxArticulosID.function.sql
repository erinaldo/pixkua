-- =============================================
-- Author: alez Lopez
-- ALTER  date: 19-ene-2011
-- Description:	Obtiene el ID de Articulos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Restaurant].[fxArticulosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdArticulo
	FROM Restaurant.Articulos
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


