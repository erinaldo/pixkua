-- =============================================
-- Author: RCO
-- Create date: 26-sep-2010
-- Description:	Obtiene una lista de búsqueda de Areas
-- =============================================
CREATE FUNCTION [Inventory].[fxAreasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdArea, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.Areas
	WHERE IdSucursal=@IdSucursal
	)


