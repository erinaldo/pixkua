-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Verifica la existencia de UnidadesMedidaTipos
-- =============================================
CREATE FUNCTION [Inventory].[fxUnidadesMedidaTiposExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdUnidadMedidaTipo FROM Inventory.UnidadesMedidaTipos WHERE IdUnidadMedidaTipo=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


