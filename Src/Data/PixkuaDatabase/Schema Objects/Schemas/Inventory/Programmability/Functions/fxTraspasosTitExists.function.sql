-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Verifica la existencia de TraspasosTit
-- =============================================
CREATE FUNCTION [Inventory].[fxTraspasosTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdTraspasoTit FROM Inventory.TraspasosTit WHERE IdTraspasoTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


