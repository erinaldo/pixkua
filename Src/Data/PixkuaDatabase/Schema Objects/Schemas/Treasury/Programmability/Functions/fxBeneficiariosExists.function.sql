-- =============================================
-- Author: alex Lopez
-- Create date: 02-dic-2011
-- Description:	Verifica la existencia de Beneficiarios
-- =============================================
CREATE FUNCTION [Treasury].[fxBeneficiariosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdBeneficiario FROM Treasury.Beneficiarios WHERE IdBeneficiario=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


