CREATE FUNCTION [Documents].[fxDocumentsStruct]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdDocumentoTipo, Codigo, Nombre
	FROM Documents.Tipos 
	WHERE IdStatus=1
		)


