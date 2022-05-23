-- =============================================
-- Author: alex Lopez
-- Create date: 14-oct-2010
-- Description:	Elimina el Status especificado.
-- =============================================
CREATE PROCEDURE [Documents].[StatusDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Documents.Status SET IdStatus=0 WHERE IdStatus=@ID


