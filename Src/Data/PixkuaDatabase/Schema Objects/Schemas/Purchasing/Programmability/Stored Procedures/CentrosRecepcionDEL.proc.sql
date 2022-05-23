-- =============================================
-- Author: alez lopez
-- Create date: 19-oct-2011
-- Description:	Elimina el CentrosRecepcion especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[CentrosRecepcionDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.CentrosRecepcion SET IdStatus=0 WHERE IdCentroRecepcion=@ID


