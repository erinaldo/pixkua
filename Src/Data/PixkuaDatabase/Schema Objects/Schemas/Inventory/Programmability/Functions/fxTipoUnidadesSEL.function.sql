CREATE FUNCTION [Inventory].[fxTipoUnidadesSEL](@IdUnidadMedidaTipo as int)
RETURNS TABLE
AS
RETURN	(
	SELECT U.IdUnidadMedida, U.Codigo, U.Nombre, T.Nombre AS Tipo, U.Base, U.Factor, U.IdStatus,
		CASE U.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.UnidadesMedida U JOIN Inventory.UnidadesMedidaTipos T
		ON U.IdUnidadMedidaTipo=T.IdUnidadMedidaTipo
	WHERE U.IdUnidadMedidaTipo=@IdUnidadMedidaTipo
		)


