-- =============================================
-- Author: RCO
-- Create date: 09-sep-2010
-- Description:	Verifica la existencia de Impuestos
-- =============================================
CREATE FUNCTION [Accounting].[fxImpuestosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdImpuesto FROM Accounting.Impuestos WHERE IdImpuesto=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


