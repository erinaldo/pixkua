-- =============================================
-- Author: alez Lopez
-- Create date: 18-oct-2010
-- Description:	Obtiene la información del Importes especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxImportesSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.Importes WHERE IdImporte=@ID)


