-- =============================================
-- Author: alez lopez
-- Create date: 19-ene-2011
-- Description:	Elimina el CentrosProduccion especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[CentrosProduccionDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	UPDATE Restaurant.CentrosProduccion SET IdStatus=0 WHERE IdCentroProduccion=@ID


