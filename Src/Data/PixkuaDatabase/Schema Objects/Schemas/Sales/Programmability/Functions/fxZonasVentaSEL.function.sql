-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene la información del ZonasVenta especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxZonasVentaSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.ZonasVenta WHERE IdZonaVenta=@ID)


