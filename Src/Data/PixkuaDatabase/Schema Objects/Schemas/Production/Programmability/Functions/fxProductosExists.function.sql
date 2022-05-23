-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Verifica la existencia de Productos
-- =============================================
CREATE FUNCTION [Production].[fxProductosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdProducto FROM Production.Productos WHERE IdProducto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


