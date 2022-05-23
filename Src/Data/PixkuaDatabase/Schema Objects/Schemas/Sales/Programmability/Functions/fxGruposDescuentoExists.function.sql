-- =============================================
-- Author: alez Lopez
-- Create date: 22-ago-2011
-- Description:	Verifica la existencia de GruposDescuento
-- =============================================
CREATE FUNCTION [Sales].[fxGruposDescuentoExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdGrupoDescuento FROM Sales.GruposDescuento WHERE IdGrupoDescuento=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


