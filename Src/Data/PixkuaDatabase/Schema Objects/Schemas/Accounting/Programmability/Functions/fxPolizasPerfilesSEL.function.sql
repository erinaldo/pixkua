-- =============================================
-- Author: alex Lopez
-- Create date: 09-oct-2010
-- Description:	Obtiene la información del PolizasPerfiles especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasPerfilesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.PolizasPerfiles WHERE IdPolizaPerfil=@ID)


