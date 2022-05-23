-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Elimina el ZonasVenta especificado.
-- =============================================
CREATE PROCEDURE [Sales].[ZonasVentaDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Sales.ZonasVenta WHERE IdZonaVenta=@ID


