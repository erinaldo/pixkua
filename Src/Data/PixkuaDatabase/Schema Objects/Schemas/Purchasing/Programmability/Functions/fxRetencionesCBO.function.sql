CREATE FUNCTION [Purchasing].[fxRetencionesCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdRetencion, Codigo, Nombre
	FROM Accounting.Retenciones
	WHERE IdStatus=1 
	)


