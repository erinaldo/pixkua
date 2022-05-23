-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Elimina el NotasConceptos especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[NotasConceptosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Accounting.NotasConceptos WHERE IdNotaConcepto=@ID


