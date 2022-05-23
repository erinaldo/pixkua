-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Elimina el Centrales especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[CentralesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.Centrales SET IdStatus=0 WHERE IdCentral=@ID


