-- =============================================
-- Author: alex Lopez
-- Create date: 30-nov-2011
-- Description:	Obtiene la información del Cajas especificado.
-- =============================================
CREATE FUNCTION [Treasury].[fxCajasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Treasury.Cajas WHERE IdCaja=@ID)


