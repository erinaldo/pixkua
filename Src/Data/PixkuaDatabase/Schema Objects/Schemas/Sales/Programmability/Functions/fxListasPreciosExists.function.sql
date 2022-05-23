-- =============================================
-- Author: alez Lopez
-- Create date: 16-ago-2011
-- Description:	Verifica la existencia de ListasPrecios
-- =============================================
CREATE FUNCTION [Sales].[fxListasPreciosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdListaPrecio FROM Sales.ListasPrecios WHERE IdListaPrecio=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


