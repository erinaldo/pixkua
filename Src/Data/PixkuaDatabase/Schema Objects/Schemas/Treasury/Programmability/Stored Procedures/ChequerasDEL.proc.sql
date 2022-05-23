-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Elimina el Chequeras especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[ChequerasDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Treasury.Chequeras SET IdStatus=0 WHERE IdChequera=@ID


