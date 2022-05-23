CREATE FUNCTION [Sales].[fxDevolucionesCausasCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdDevolucionCausa, Codigo, Nombre
	FROM Sales.DevolucionesCausas
	WHERE IdEmpresa=@IdEmpresa AND IdStatus=1
		)


