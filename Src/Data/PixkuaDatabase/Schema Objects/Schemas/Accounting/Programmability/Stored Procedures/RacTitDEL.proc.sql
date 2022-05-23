-- =============================================
-- Author: alex Lopez
-- Create date: 08-oct-2010
-- Description:	Elimina el RacTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[RacTitDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Accounting.RacTit SET IdStatus=0 WHERE IdRacTit=@ID


