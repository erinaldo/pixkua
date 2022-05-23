-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Obtiene la información del Chequeras especificado.
-- =============================================
CREATE FUNCTION [Treasury].[fxChequerasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Treasury.Chequeras WHERE IdChequera=@ID)


