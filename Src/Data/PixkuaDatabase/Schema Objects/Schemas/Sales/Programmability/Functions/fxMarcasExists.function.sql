-- =============================================
-- Author: RCO
-- Create date: 15-oct-2010
-- Description:	Verifica la existencia de Marcas
-- =============================================
CREATE FUNCTION [Sales].[fxMarcasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdMarca FROM Sales.Marcas WHERE IdMarca=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


