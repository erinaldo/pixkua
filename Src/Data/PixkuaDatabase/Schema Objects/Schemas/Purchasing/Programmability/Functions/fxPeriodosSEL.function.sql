-- =============================================
-- Author: alez Lopez
-- Create date: 01-nov-2011
-- Description:	Obtiene la información del Periodos especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxPeriodosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Purchasing.Periodos WHERE IdPeriodo=@ID)


