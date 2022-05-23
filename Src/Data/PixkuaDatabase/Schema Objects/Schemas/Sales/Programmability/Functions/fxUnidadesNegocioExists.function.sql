-- =============================================
-- Author: RCO
-- Create date: 03-sep-2010
-- Description:	Verifica la existencia de UnidadesNegocio
-- =============================================
CREATE FUNCTION [Sales].[fxUnidadesNegocioExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdUnidadNegocio FROM Sales.UnidadesNegocio WHERE IdUnidadNegocio=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


