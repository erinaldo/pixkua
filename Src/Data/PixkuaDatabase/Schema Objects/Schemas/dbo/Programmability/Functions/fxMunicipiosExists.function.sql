-- =============================================
-- Author: RCO
-- Create date: 23-mar-2009
-- Description:	Verifica la existencia de Municipios
-- =============================================
CREATE FUNCTION [dbo].[fxMunicipiosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdMunicipio FROM dbo.Municipios WHERE IdMunicipio=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


