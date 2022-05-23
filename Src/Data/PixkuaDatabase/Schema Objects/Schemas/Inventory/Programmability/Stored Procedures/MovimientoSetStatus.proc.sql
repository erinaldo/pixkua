CREATE PROCEDURE [Inventory].[MovimientoSetStatus]
	@IdMovimientoTit as char(18),
	@IdStatus as int
AS
	SET NOCOUNT ON
		
	UPDATE Inventory.MovimientosTit SET IdStatus = @IdStatus
	WHERE IdMovimientoTit=@IdMovimientoTit AND Fecha = Documents.fxDocumentDate(@IdMovimientoTit)


