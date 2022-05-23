-- =============================================
-- Author: RCO
-- Create date: 10-sep-2010
-- Description:	Obtiene la información del Divisas especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxDivisasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.Divisas WHERE IdDivisa=@ID)


