-- =============================================
-- Author: alez Lopez
-- ALTER  date: 22-ago-2011
-- Description:	Obtiene el ID de GruposDescuento en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxGruposDescuentoID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdGrupoDescuento
	FROM Sales.GruposDescuento
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


