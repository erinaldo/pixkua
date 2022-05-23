CREATE PROCEDURE [Accounting].[CFDNuevoFolio]
	@IdCFDSerie as int,
	@Folio as int out
AS
	SET NOCOUNT ON
	/*Incrementar el folio de la factura*/
	UPDATE Accounting.CFDSeries SET UltimoFolio=UltimoFolio + 1
	WHERE IdCFDSerie=@IdCFDSerie

	/*Obtener el ultimo folio de la serie*/
	SELECT @Folio=UltimoFolio
	FROM Accounting.CFDSeries
	WHERE IdCFDSerie=@IdCFDSerie


