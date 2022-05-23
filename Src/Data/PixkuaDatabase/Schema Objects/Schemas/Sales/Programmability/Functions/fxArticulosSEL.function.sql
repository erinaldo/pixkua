-- =============================================
-- Author: RCO
-- Create date: 14-oct-2010
-- Description:	Obtiene la información del Articulos especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxArticulosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT A.*, UM.IdUnidadMedidaTipo
	FROM Sales.Articulos A JOIN Inventory.UnidadesMedida UM
		ON A.IdUnidadMedida=UM.IdUnidadMedida
	WHERE A.IdArticulo=@ID
	)


