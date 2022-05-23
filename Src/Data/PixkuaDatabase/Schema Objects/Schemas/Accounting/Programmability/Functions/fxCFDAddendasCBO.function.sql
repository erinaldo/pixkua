CREATE FUNCTION [Accounting].[fxCFDAddendasCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdCFDAddenda, Codigo, Nombre
	FROM Accounting.CFDAddendas
	WHERE IdStatus=1
		)


