-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 01-Jun-2006
-- Description:	Obtiene la lista de accesos a sucursales de un usuario
-- =============================================
CREATE FUNCTION [dbo].[fxUsuarioSucurales](@IdUsuario AS int)
RETURNS TABLE
AS
RETURN (
	SELECT S.IdSucursal, S.IdEmpresa, S.Nombre, IsNull(US.Acceso, 0) AS Acceso
	FROM Sucursales S LEFT JOIN UsuariosSucursales US
		 ON US.IdSucursal=S.IdSucursal 
		AND US.IdUsuario=@IdUsuario
		)


