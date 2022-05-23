CREATE FUNCTION [Accounting].[fxPolizasTipoCBO]()
RETURNS TABLE
AS 
	RETURN( SELECT IdPolizaTipo as Id, Nombre as Descripcion
			FROM Accounting.PolizasTipos)


