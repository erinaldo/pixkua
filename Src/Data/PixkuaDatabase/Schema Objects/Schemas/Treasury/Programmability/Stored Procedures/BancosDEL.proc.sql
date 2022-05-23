-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Elimina el Bancos especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[BancosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Treasury.Bancos SET IdStatus=0 WHERE IdBanco=@ID


