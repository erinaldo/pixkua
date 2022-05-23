CREATE FUNCTION [Inventory].[fxAreasCBO](@IdSucursal as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdArea, Codigo, Nombre, IdStatus
	FROM Inventory.Areas
	WHERE IdSucursal=@IdSucursal
		)


