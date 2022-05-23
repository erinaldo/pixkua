CREATE FUNCTION [Documents].[fxTipoWorkflowSEL](@IdDocumentoTipo as int)
RETURNS TABLE
RETURN (SELECT IdWorkflow,T.IdDocumentoTipo,W.IdStatus,S.Status,Secuencia,T.Nombre AS Tipo
		FROM Documents.Workflow W
		INNER JOIN Documents.Status S ON S.IdStatus=W.IdStatus
		INNER JOIN Documents.Tipos T ON T.IdDocumentoTipo=W.IdDocumentoTipo
		WHERE T.IdDocumentoTipo=@IdDocumentoTipo
)


