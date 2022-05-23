-- =============================================
-- Author: RCO
-- Create date: 01-nov-2011
-- Description:	Elimina el ZonasCompra especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[ZonasCompraDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Purchasing.ZonasCompra WHERE IdZonaCompra=@ID


