CREATE FUNCTION [Documents].[fxWorkflowStruct]()
RETURNS TABLE
AS
RETURN	(
	select W.IdDocumentoTipo, T.Nombre AS Tipo, W.IdStatus, S.Status, W.Secuencia
	from Documents.Tipos T JOIN Documents.Workflow W
		ON T.IdDocumentoTipo=W.IdDocumentoTipo
	join Documents.Status S
		ON W.IdStatus=S.IdStatus
	where T.IdStatus=1
		)


