-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Verifica la existencia de NotasConceptos
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasConceptosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdNotaConcepto FROM Accounting.NotasConceptos WHERE IdNotaConcepto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


