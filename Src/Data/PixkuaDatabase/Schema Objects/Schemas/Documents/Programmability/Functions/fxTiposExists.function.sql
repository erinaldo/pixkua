-- =============================================
-- Author: alex opez
-- Create date: 13-oct-2010
-- Description:	Verifica la existencia de Tipos
-- =============================================
CREATE FUNCTION [Documents].[fxTiposExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdDocumentoTipo FROM Documents.Tipos WHERE IdDocumentoTipo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


