CREATE FUNCTION [Sales].[fxZonasVentaCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdZonaVenta, Codigo, Nombre
	FROM Sales.ZonasVenta
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


