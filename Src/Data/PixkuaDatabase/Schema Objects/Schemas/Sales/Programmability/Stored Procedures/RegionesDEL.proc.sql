-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Elimina el Regiones especificado.
-- =============================================
CREATE PROCEDURE [Sales].[RegionesDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.Regiones WHERE IdRegion=@ID


