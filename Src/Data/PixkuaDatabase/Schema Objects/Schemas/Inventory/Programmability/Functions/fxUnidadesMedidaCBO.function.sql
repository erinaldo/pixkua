CREATE FUNCTION [Inventory].[fxUnidadesMedidaCBO]()
RETURNS TABLE
AS
RETURN	(
	SELECT IdUnidadMedida, IdUnidadMedidaTipo, Codigo, Nombre, Abreviatura
	FROM Inventory.UnidadesMedida
	WHERE IdStatus=1
		)


