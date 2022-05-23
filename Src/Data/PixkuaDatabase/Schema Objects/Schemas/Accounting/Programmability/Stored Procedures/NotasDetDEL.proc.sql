-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Elimina el NotasDet especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[NotasDetDEL]
	@Id AS char(18),
	@IdNotaConcepto as int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.NotasDet 
	WHERE IdNotaTit=@Id  and Fecha=Documents.fxDocumentDate(@Id) and IdNotaConcepto=@IdNotaConcepto


