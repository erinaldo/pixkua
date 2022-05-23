-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Mar-2005
-- Description:	Obtiene el ID de Sucursal en base a su código de usuario.
-- =============================================
CREATE FUNCTION [dbo].[fxSucursalesID]
	(
		@Codigo AS varchar(10),@IdSucursal as int
	)
RETURNS int
AS
BEGIN
	DECLARE @ID AS int
	
	SELECT @ID=IdSucursal
	FROM Sucursales
	WHERE Codigo=@Codigo

	RETURN IsNull(@ID, 0)
END


