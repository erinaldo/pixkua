-- =============================================
-- Author: alex opez
-- Create date: 13-oct-2010
-- Description:	Elimina el Tipos especificado.
-- =============================================
CREATE PROCEDURE [Documents].[TiposDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Documents.Tipos SET IdStatus= 0 WHERE IdDocumentoTipo=@ID


