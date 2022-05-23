-- =============================================
-- Author: alez lopez
-- Create date: 29-ago-2011
-- Description:	Verifica la existencia de Vendedores
-- =============================================
CREATE FUNCTION [Sales].[fxVendedoresExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdVendedor FROM Sales.Vendedores WHERE IdVendedor=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


