-- =============================================
-- Author: RCO
-- Create date: 02-nov-2010
-- Description:	Verifica la existencia de Operadores
-- =============================================
CREATE FUNCTION [dbo].[fxOperadoresExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdOperador FROM dbo.Operadores WHERE IdOperador=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


