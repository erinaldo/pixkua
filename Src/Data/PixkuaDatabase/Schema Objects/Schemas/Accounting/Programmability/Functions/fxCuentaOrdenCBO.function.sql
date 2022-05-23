CREATE FUNCTION [Accounting].[fxCuentaOrdenCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdCuentaOrden AS Id, Orden as Nombre
	FROM Accounting.CuentasOrden
	WHERE IdStatus=1
		)


