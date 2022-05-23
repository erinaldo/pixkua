-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Verifica la existencia de OrdenesTit
-- =============================================
CREATE FUNCTION [Purchasing].[fxOrdenesTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdOrdenTit FROM Purchasing.OrdenesTit WHERE IdOrdenTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


