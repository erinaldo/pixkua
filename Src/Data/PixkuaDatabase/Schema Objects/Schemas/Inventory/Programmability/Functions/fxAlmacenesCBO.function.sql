CREATE FUNCTION [Inventory].[fxAlmacenesCBO](@IdSucursal as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdAlmacen, Codigo, Nombre, IdArea
	FROM Inventory.Almacenes
	WHERE IdStatus=1 AND IdSucursal=@IdSucursal
		)


