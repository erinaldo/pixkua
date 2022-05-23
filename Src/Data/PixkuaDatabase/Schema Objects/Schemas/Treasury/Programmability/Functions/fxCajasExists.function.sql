-- =============================================
-- Author: alex Lopez
-- Create date: 30-nov-2011
-- Description:	Verifica la existencia de Cajas
-- =============================================
CREATE FUNCTION [Treasury].[fxCajasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCaja FROM Treasury.Cajas WHERE IdCaja=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


