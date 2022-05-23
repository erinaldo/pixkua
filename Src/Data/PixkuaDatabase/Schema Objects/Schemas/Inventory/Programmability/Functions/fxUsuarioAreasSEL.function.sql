CREATE FUNCTION [Inventory].[fxUsuarioAreasSEL](@IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT A.IdArea, A.Nombre, A.IdSucursal, Cast(IsNull(AU.IdAreaUsuario, 0) AS Bit) AS Selected
	FROM Inventory.Areas A LEFT JOIN Inventory.AreasUsuarios AU
		ON A.IdArea=AU.IdArea AND AU.IdUsuario=@IdUsuario
	JOIN dbo.UsuariosSucursales US
		ON A.IdSucursal=US.IdSucursal AND US.IdUsuario=@IdUsuario
	WHERE A.IdStatus=1
		)


