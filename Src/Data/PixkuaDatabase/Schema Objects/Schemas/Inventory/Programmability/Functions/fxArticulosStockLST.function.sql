-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Obtiene una lista de búsqueda de ArticulosStock
-- =============================================
CREATE FUNCTION [Inventory].[fxArticulosStockLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT AX.IdArticuloStock, AX.Nombre, AX.EAN, U.Nombre AS UnidadMedida, AX.Codigo,
		CASE AX.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.ArticulosStock AX JOIN Inventory.UnidadesMedida U
		ON AX.IdUnidadMedida=U.IdUnidadMedida
	WHERE AX.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)	
	)


