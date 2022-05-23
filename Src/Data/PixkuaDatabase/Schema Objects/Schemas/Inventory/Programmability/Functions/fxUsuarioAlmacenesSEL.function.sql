CREATE FUNCTION [Inventory].[fxUsuarioAlmacenesSEL](@IdUsuario as int)
RETURNS TABLE
AS
RETURN	(
	SELECT A.IdAlmacen, AR.Nombre AS Area, A.IdArea, A.Nombre, A.IdSucursal, Cast(IsNull(AU.IdAlmacenUsuario, 0) AS Bit) AS Selected,
		IsNull(AU.Entrada, 0) AS Entrada, IsNull(AU.Salida, 0) AS Salida
	FROM Inventory.Almacenes A LEFT JOIN Inventory.AlmacenesUsuarios AU
		ON A.IdAlmacen=AU.IdAlmacen AND AU.IdUsuario=@IdUsuario
	JOIN Inventory.Areas AR
		ON A.IdArea=AR.IdArea
	JOIN dbo.UsuariosSucursales US
		ON A.IdSucursal=US.IdSucursal AND US.IdUsuario=@IdUsuario
	WHERE A.IdStatus=1
		)


