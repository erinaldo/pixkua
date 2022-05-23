-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene la información del FormasPago especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxFormasPagoSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.FormasPago WHERE IdFormaPago=@ID)


