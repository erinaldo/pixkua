CREATE FUNCTION [Inventory].[fxAreaAlmacenesSEL](@IdArea as int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdAlmacen, Nombre, Codigo, IdStatus,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.Almacenes
	WHERE IdArea=@IdArea 
	)


