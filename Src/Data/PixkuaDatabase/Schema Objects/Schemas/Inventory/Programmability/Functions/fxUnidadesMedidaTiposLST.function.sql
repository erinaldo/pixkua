-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Obtiene una lista de búsqueda de UnidadesMedidaTipos
-- =============================================
CREATE FUNCTION [Inventory].[fxUnidadesMedidaTiposLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdUnidadMedidaTipo, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.UnidadesMedidaTipos
	)


