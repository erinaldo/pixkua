-- =============================================
-- Author: alex Lopez
-- Create date: 13-oct-2010
-- Description:	Obtiene la información del Entidades especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxEntidadesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.Entidades WHERE IdEntidad=@ID)


