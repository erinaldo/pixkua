-- =============================================
-- Author: RCO
-- Create date: 02-nov-2011
-- Description:	Obtiene la información del Servicios especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxServiciosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.Servicios WHERE IdServicio=@ID)


