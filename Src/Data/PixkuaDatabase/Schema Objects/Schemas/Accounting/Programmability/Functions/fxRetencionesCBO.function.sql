CREATE FUNCTION [Accounting].[fxRetencionesCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdRetencion, Codigo, Nombre, Abrev, Porcentaje*100 as Porcentaje,CAST(0 as decimal(19,4))AS Monto
	FROM Accounting.Retenciones
	WHERE IdStatus=1
		)


