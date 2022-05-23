CREATE PROCEDURE [Inventory].[TraspasoAplicarMovtos]
	@IdTraspasoTit as char(18),
	@IdEntrada as char(18),
	@IdSalida as char(18)
AS
	SET NOCOUNT ON
	
	DECLARE @FechaDocumento as datetime
	SET @FechaDocumento=Documents.fxDocumentDate(@IdTraspasoTit)

	UPDATE Inventory.TraspasosTit 
	SET IdMovimientoIN=@IdEntrada, IdMovimientoOUT=@IdSalida
	WHERE IdTraspasoTit=@IdTraspasoTit AND Fecha=@FechaDocumento


