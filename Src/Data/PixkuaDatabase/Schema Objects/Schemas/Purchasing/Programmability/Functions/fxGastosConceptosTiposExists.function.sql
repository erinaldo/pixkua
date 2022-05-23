-- =============================================
-- Author: alex Lopez
-- Create date: 15-nov-2011
-- Description:	Verifica la existencia de GastosConceptosTipos
-- =============================================
CREATE FUNCTION [Purchasing].[fxGastosConceptosTiposExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdGastoConceptoTipo FROM Purchasing.GastosConceptosTipos WHERE IdGastoConceptoTipo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


