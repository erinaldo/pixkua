-- =============================================
-- Author: RCO
-- Create date: 14-oct-2010
-- Description:	Obtiene una lista de búsqueda de ArticulosPresentaciones
-- =============================================
CREATE FUNCTION [Sales].[fxArticulosPresentacionesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE             
AS
RETURN
	(
	SELECT AX.IdArticuloStock, AX.Nombre, M.Nombre AS Marca,A.Modelo, UM.Nombre AS [Unidad Venta],  
		EC.NamedPath AS [Estructura Comercial], AX.Codigo,ZV.Nombre AS [Zona Venta],
		CASE A.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.ArticulosPresentaciones AS AP
		JOIN Inventory.ArticulosStock AX ON AX.IdArticuloStock=AP.IdArticuloStock
		JOIN Sales.Articulos A ON A.IdArticulo=AP.IdArticulo
		JOIN Inventory.UnidadesMedida UM ON A.IdUnidadMedida=UM.IdUnidadMedida
		JOIN Sales.Marcas M	ON A.IdMarca=M.IdMarca
		JOIN Sales.EstCom EC ON A.IdEstCom=EC.IdEstCom	
		JOIN sales.ArticulosZonasVenta AZV ON AZV.IdArticuloStock=AX.IdArticuloStock 	
		JOIN Sales.ZonasVenta ZV ON ZV.IdZonaVenta=AZV.IdZonaVenta
	WHERE A.IdEmpresa = (SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)			
		AND AZV.IdZonaVenta=(SELECT IdZonaVenta FROM Sales.UnidadesNegocio WHERE IdSucursal=@IdSucursal)
	)


