CREATE FUNCTION [Accounting].[fxCuentaTipoCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdCuentaTipo, CuentaTipo as Nombre
	FROM Accounting.CuentasTipos
	--WHERE IdStatus=1
		)


