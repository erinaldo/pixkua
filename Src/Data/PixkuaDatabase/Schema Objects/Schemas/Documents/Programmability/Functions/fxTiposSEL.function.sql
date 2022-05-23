-- =============================================
-- Author: alex opez
-- Create date: 13-oct-2010
-- Description:	Obtiene la información del Tipos especificado.
-- =============================================
CREATE FUNCTION [Documents].[fxTiposSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Documents.Tipos WHERE IdDocumentoTipo=@ID)


