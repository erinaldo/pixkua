CREATE FUNCTION [Inventory].[fxAlmacenesByUsuarioCBO](@IdSucursal as int, @IdArea as int, @IdUsuario as int, @Acceso as int)
RETURNS TABLE
AS
RETURN	(
	SELECT A.IdAlmacen, A.Codigo, A.Nombre, A.IdArea, AR.Nombre AS Area
	FROM Inventory.Almacenes A JOIN Inventory.AlmacenesUsuarios AU
		ON A.IdAlmacen=AU.IdAlmacen
	JOIN Inventory.Areas AR
		ON A.IdArea=AR.IdArea
	WHERE A.IdStatus=1 AND AU.IdUsuario=@IdUsuario
		AND (A.IdArea=@IdArea OR @IdArea=0)
		AND (@Acceso=0 OR (@Acceso=1 AND AU.Entrada=1) OR (@Acceso=2 AND AU.Salida=1) OR (@Acceso=3 AND (AU.Salida=1 OR AU.Entrada=1)))
		)


