-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Obtiene una lista de búsqueda de UnidadesMedida
-- =============================================
CREATE FUNCTION [Inventory].[fxUnidadesMedidaLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT U.IdUnidadMedida, U.Nombre, T.Nombre AS [Tipo Unidad], U.Codigo,
		CASE U.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.UnidadesMedida U JOIN Inventory.UnidadesMedidaTipos T
		ON U.IdUnidadMedidaTipo=T.IdUnidadMedidaTipo
	)


