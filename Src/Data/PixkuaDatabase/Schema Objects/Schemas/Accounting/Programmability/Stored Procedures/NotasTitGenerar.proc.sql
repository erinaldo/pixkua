CREATE PROCEDURE [Accounting].[NotasTitGenerar]
	@IdNotaTit as char(18), 
	@IdCFDSerie as int,
	@Folio as int,
	@Fecha as datetime
AS
	SET NOCOUNT ON
		
	UPDATE Accounting.NotasTit
	SET IdCFDSerie=@IdCFDSerie, FolioNota=@Folio, FechaNota=@Fecha
	WHERE IdNotaTit=@IdNotaTit AND Fecha=Documents.fxDocumentDate(@IdNotaTit)


