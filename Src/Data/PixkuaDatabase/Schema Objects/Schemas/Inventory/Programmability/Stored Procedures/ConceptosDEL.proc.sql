-- =============================================
-- Author: RCO
-- Create date: 13-oct-2010
-- Description:	Elimina el Conceptos especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[ConceptosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.Conceptos WHERE IdConcepto=@ID


