-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Verifica la existencia de VentasTit
-- =============================================
CREATE FUNCTION [Sales].[fxVentasTitExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdVentaTit FROM Sales.VentasTit WHERE IdVentaTit=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


