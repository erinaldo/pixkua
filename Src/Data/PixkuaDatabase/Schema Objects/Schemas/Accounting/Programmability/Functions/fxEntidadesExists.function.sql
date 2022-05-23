-- =============================================
-- Author: alex Lopez
-- Create date: 13-oct-2010
-- Description:	Verifica la existencia de Entidades
-- =============================================
CREATE FUNCTION [Accounting].[fxEntidadesExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdEntidad FROM Accounting.Entidades WHERE IdEntidad=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


