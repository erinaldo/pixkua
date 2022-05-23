-- =============================================
-- Author: alez Lopez
-- Create date: 31-ago-2011
-- Description:	Obtiene la información del Terminales especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxTerminalesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.Terminales WHERE IdTerminal=@ID)


