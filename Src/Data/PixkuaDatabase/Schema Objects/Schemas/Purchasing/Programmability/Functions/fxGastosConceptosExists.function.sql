-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Verifica la existencia de GastosConceptos
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosConceptosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdGastoConcepto FROM Purchasing.GastosConceptos WHERE IdGastoConcepto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


