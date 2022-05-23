CREATE FUNCTION [Accounting].[fxImpuestosCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdImpuesto, Codigo, Nombre, Abrev, Porcentaje*100 AS Porcentaje,TipoImpuesto,CAST(0 as decimal(19,4))AS Monto
	FROM Accounting.Impuestos
	WHERE IdStatus=1
		)


