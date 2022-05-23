CREATE FUNCTION [Accounting].[fxPolizasSumarizacionCBO]()
RETURNS TABLE
AS 
	RETURN( SELECT IdPolizaSumarizacion as Id,Sumarizacion as Descripcion
			FROM Accounting.PolizasSumarizacion)


