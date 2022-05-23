-- =============================================
-- Author: alez Lopez
-- Create date: 18-oct-2010
-- Description:	Elimina el Importes especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[ImportesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE  Accounting.Importes SET IdStatus=0 WHERE IdImporte=@ID


