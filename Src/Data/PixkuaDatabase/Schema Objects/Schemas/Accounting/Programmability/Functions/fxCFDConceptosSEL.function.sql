CREATE FUNCTION [Accounting].[fxCFDConceptosSEL](@FechaComprobante as datetime, @IdCFDSerie as int, @Folio as int)
RETURNS TABLE
AS
RETURN	(
	SELECT *
	FROM Accounting.CFDConceptos
	WHERE FechaComprobante=@FechaComprobante AND IdCFDSerie=@IdCFDSerie AND Folio=@Folio
		)


