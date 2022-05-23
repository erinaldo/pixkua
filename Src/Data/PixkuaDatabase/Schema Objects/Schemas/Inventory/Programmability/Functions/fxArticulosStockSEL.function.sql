-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Obtiene la información del ArticulosStock especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxArticulosStockSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT AX.*, UM.Nombre AS UnidadMedida, UM.IdUnidadMedidaTipo
	FROM Inventory.ArticulosStock AX JOIN Inventory.UnidadesMedida UM
		ON AX.IdUnidadMedida=UM.IdUnidadMedida
	WHERE IdArticuloStock=@ID)


