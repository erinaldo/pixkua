CREATE FUNCTION [Inventory].[fxAreasByUsuarioSEL](@IdUsuario as int, @IdSucursal as int)
RETURNS TABLE
AS
RETURN	(
	SELECT A.IdArea, A.Codigo, A.Nombre
	FROM Inventory.Areas A JOIN Inventory.AreasUsuarios AU
		ON A.IdArea=AU.IdArea
	WHERE AU.IdUsuario=@IdUsuario AND A.IdStatus=1
		AND (A.IdSucursal=@IdSucursal OR @IdSucursal=0)
		)


