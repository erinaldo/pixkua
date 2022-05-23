-- =============================================
-- Author: RCO
-- Create date: 01-jul-2011
-- Description:	Obtiene la información del Cajeros especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxCajerosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Cajeros WHERE IdCajero=@ID)


