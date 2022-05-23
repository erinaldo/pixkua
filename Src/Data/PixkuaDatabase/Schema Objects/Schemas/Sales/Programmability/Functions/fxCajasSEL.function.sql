-- =============================================
-- Author: alez Lopez
-- Create date: 30-jun-2011
-- Description:	Obtiene la información del Cajas especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxCajasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Cajas WHERE IdCaja=@ID)


