-- =============================================
-- Author: alex Lopez
-- Create date: 08-oct-2010
-- Description:	Obtiene la información del RacTit especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxRacTitSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.RacTit WHERE IdRacTit=@ID)


