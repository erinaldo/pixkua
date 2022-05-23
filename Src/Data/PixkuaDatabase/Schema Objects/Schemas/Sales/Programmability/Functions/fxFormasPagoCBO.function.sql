CREATE FUNCTION [Sales].[fxFormasPagoCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdFormaPago, Codigo, Nombre
	FROM Sales.FormasPago
	WHERE IdStatus=1
		)


