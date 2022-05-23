-- =============================================
-- Author: alez Lopez
-- Create date: 01-nov-2011
-- Description:	Elimina el Periodos especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[PeriodosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.Periodos SET IdStatus=0 WHERE IdPeriodo=@ID


