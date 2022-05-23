CREATE FUNCTION [Accounting].[fxContabilizacionDocumentosDetSEL](@IdContabilizacionDocumentoTit as int)
RETURNS TABLE
AS
	RETURN(	SELECT W.*,S.Status,IsNull(CD.IdContabilizacionDocumentoDet,0)AS IdContabilizacionDocumentoDet,IsNull(CD.Variante,0) AS Variante,IsNull(CD.IdRacTit,0) AS IdRacTit,RT.Nombre AS Rac
			FROM Accounting.ContabilizacionDocumentosTit AS CT
			INNER JOIN Documents.Tipos DT ON DT.IdDocumentoTipo=CT.IdDocumentoTipo
			INNER JOIN Documents.Workflow W ON W.IdDocumentoTipo=DT.IdDocumentoTipo
			INNER JOIN Documents.Status S ON S.IdStatus=W.IdStatus
			 LEFT JOIN Accounting.ContabilizacionDocumentosDet CD ON CD.IdContabilizacionDocumentoTit=CT.IdContabilizacionDocumentoTit AND CD.IdStatus=W.IdStatus
			 LEFT JOIN Accounting.RacTit RT ON RT.IdRacTit=CD.IdRacTit
			WHERE CT.IdContabilizacionDocumentoTit=@IdContabilizacionDocumentoTit
)


