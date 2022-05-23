-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Elimina el ComandaTit especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[ComandaTitDEL]
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Restaurant.ComandaTit WHERE IdComandaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


