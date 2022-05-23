-- =============================================
-- Author: alex Lopez
-- Create date: 23-nov-2011
-- Description:	Verifica la existencia de Gastos
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosExists](@ID AS char(18))
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdGasto FROM Purchasing.Gastos WHERE IdGasto=@ID and Fecha=Documents.fxDocumentDate(@Id))
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


