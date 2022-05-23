-- =============================================
-- Author: RCO
-- Create date: 27-sep-2010
-- Description:	Obtiene una lista de búsqueda de Almacenes
-- =============================================
CREATE FUNCTION [Inventory].[fxAlmacenesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdAlmacen, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.Almacenes
	WHERE IdSucursal=@IdSucursal
	)


