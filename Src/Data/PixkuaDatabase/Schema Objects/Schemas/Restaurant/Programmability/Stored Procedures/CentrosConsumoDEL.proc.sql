-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Elimina el CentrosConsumo especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[CentrosConsumoDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Restaurant.CentrosConsumo WHERE IdCentroConsumo=@ID


