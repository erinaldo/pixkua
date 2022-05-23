CREATE FUNCTION [Accounting].[fxContabilizacionDocumentosDetSelNew](@IdDocumentoTipo as int)
RETURNS TABLE
AS
	RETURN(	SELECT W.*,0 AS IdContabilizacionDocumentoDet,cast(0 as int)IdRacTit,'' AS Rac,CAST(0 AS BIT) AS Variante
			FROM [Documents].[fxTipoWorkflowSEL](@IdDocumentoTipo) AS W
			--LEFT JOIN Accounting.ContabilizacionDocumentosTit AS T ON T.IdDocumentoTipo=W.IdDocumentoTipo
			--LEFT JOIN Accounting.ContabilizacionDocumentosDet AS D ON D.IdContabilizacionDocumentoTit=T.IdContabilizacionDocumentoTit
			--LEFT JOIN Accounting.RacTit RT ON RT.IdRacTit=D.IdRacTit
)


