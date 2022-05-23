CREATE PROCEDURE [Accounting].[CFDConceptosDEL]
	@FechaComprobante as datetime,
	@IdCFDSerie as int,
	@Folio as int
AS
	SET NOCOUNT ON

	DELETE Accounting.CFDConceptos
	WHERE FechaComprobante=@FechaComprobante AND IdCFDSerie=@IdCFDSerie AND Folio=@Folio


