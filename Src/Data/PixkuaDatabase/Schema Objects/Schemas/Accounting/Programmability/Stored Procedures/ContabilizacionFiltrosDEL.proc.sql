CREATE PROCEDURE [Accounting].[ContabilizacionFiltrosDEL]
@IdContabilizacionDocumentoDet as int
AS
	DELETE Accounting.ContabilizacionFiltros WHERE IdContabilizacionDocumentoDet=@IdContabilizacionDocumentoDet


