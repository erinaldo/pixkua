-- =============================================
-- Author: alez Lopez
-- Create date: 30-jun-2011
-- Description:	Verifica la existencia de Cajas
-- =============================================
CREATE FUNCTION [Sales].[fxCajasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCaja FROM Sales.Cajas WHERE IdCaja=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


