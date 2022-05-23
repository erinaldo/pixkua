CREATE FUNCTION [Sales].[fxClasificacionesEntidadesCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdClasificacionEntidad, Nombre
	FROM Sales.ClasificacionesEntidades
		)


