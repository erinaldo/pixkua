CREATE FUNCTION [Inventory].[fxClasificacionesEntidadesCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdClasificacionEntidad, Nombre
	FROM Inventory.ClasificacionesEntidades
		)


