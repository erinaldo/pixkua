-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Verifica la existencia de UnidadesMedida
-- =============================================
CREATE FUNCTION [Inventory].[fxUnidadesMedidaExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdUnidadMedida FROM Inventory.UnidadesMedida WHERE IdUnidadMedida=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


