-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Verifica la existencia de MovimientosTit
-- =============================================
CREATE FUNCTION [Inventory].[fxMovimientosTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdMovimientoTit FROM Inventory.MovimientosTit WHERE IdMovimientoTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


