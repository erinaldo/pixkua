-- =============================================
-- Author: RCO
-- Create date: 13-oct-2010
-- Description:	Verifica la existencia de Conceptos
-- =============================================
CREATE FUNCTION [Inventory].[fxConceptosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdConcepto FROM Inventory.Conceptos WHERE IdConcepto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


