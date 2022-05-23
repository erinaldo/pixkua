-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Verifica la existencia de Impresoras
-- =============================================
CREATE FUNCTION [dbo].[fxImpresorasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdImpresora FROM dbo.Impresoras WHERE IdImpresora=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


