-- =============================================
-- Author: alez Lopez
-- Create date: 31-ago-2011
-- Description:	Elimina el Terminales especificado.
-- =============================================
CREATE PROCEDURE [Sales].[TerminalesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Sales.Terminales SET IdStatus=0 WHERE IdTerminal=@ID


