-- =============================================
-- Author: alex Lopez
-- Create date: 13-oct-2010
-- Description:	Elimina el Entidades especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[EntidadesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Accounting.Entidades SET IdStatus =1 WHERE IdEntidad=@ID


