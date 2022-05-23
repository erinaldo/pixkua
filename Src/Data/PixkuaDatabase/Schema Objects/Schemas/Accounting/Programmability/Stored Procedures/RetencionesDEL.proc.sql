-- =============================================
-- Author: alex Lopez
-- Create date: 24-nov-2011
-- Description:	Elimina el Retenciones especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[RetencionesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Accounting.Retenciones SET IdStatus=0 WHERE IdRetencion=@ID


