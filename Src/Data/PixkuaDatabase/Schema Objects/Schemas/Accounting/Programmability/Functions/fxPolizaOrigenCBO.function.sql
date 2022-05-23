CREATE FUNCTION [Accounting].[fxPolizaOrigenCBO]()
RETURNS TABLE
AS 
	RETURN( SELECT IdPolizaOrigen as Id,Origen as Descripcion
			FROM Accounting.PolizasOrigen)


