-- =============================================
-- Author: Victor Moreno
-- Create date: 01-dic-2016
-- Description:	Obtiene una lista de búsqueda de OrdenesTrabajo
-- =============================================
CREATE FUNCTION Production.fxOrdenesTrabajoLST(@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdOrdenTrabajo, OT.Nombre, [AS].Codigo , [AS].Nombre  AS Articulo,
		CASE OT.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Production.OrdenesTrabajo OT
	JOIN Inventory.ArticulosStock [AS] ON [AS].IdArticuloStock = OT.IdArticuloStock
	WHERE OT.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)