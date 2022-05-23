-- =============================================
-- Author: RCO
-- Create date: 01-nov-2011
-- Description:	Obtiene la información del ZonasCompra especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxZonasCompraSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.ZonasCompra WHERE IdZonaCompra=@ID)


