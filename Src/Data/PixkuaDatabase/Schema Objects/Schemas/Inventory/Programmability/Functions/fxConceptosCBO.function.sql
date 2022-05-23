CREATE FUNCTION [Inventory].[fxConceptosCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdConcepto, Codigo, Nombre, IdDocumentoTipo, Tipo, Automatico
	FROM Inventory.Conceptos
	WHERE IdStatus=1
		)


