-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene la información del Servicios especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxServiciosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Servicios WHERE IdServicio=@ID)


