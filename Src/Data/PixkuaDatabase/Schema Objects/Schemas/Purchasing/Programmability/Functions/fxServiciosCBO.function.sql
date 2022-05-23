CREATE FUNCTION [Purchasing].[fxServiciosCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdServicio, Codigo, Nombre
	FROM Purchasing.Servicios
	WHERE IdEmpresa=@IdEmpresa AND IdStatus=1
		)


