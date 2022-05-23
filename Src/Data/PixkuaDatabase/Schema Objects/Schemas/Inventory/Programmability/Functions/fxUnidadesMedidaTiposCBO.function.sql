CREATE FUNCTION [Inventory].[fxUnidadesMedidaTiposCBO]()
RETURNS TABLE
AS
RETURN	
		(
	SELECT IdUnidadMedidaTipo, Codigo, Nombre
	FROM Inventory.UnidadesMedidaTipos
	WHERE IdStatus=1
		)


