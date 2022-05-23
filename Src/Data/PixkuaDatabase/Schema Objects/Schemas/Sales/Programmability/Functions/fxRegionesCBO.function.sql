CREATE FUNCTION [Sales].[fxRegionesCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdRegion, Codigo, Nombre
	FROM Sales.Regiones
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


