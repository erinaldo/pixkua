CREATE FUNCTION [Purchasing].[fxZonasCompraCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdZonaCompra, Codigo, Nombre
	FROM Purchasing.ZonasCompra
	WHERE IdEmpresa=@IdEmpresa AND IdStatus=1
		)


