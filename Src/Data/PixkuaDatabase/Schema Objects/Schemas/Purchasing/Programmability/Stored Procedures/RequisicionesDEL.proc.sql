-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Elimina el Requisiciones especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[RequisicionesDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.Requisiciones WHERE IdRequisicion=@ID AND Fecha = Documents.fxDocumentDate(@Id)


