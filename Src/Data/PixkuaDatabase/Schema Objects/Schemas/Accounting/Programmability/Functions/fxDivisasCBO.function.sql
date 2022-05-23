CREATE FUNCTION [Accounting].[fxDivisasCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdDivisa, Codigo, Nombre, Abrev
	FROM Accounting.Divisas
	WHERE IdStatus=1
		)


