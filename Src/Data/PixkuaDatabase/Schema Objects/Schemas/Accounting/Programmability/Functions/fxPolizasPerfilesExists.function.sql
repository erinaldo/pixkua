-- =============================================
-- Author: alex Lopez
-- Create date: 09-oct-2010
-- Description:	Verifica la existencia de Polizas
-- =============================================
CREATE FUNCTION [Accounting].[fxPolizasPerfilesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdPolizaPerfil FROM Accounting.PolizasPerfiles WHERE IdPolizaPerfil=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


