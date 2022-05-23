-- =============================================
-- Author: RCO
-- Create date: 14-oct-2010
-- Description:	Obtiene una lista de búsqueda de Articulos
-- =============================================
CREATE FUNCTION [Sales].[fxArticulosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT A.IdArticulo, A.Nombre, A.Modelo, UM.Nombre AS [Unidad Venta], M.Nombre AS Marca, 
		EC.NamedPath AS [Estructura Comercial], A.Codigo,
		CASE A.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Articulos A JOIN Inventory.UnidadesMedida UM
		ON A.IdUnidadMedida=UM.IdUnidadMedida
	JOIN Sales.Marcas M
		ON A.IdMarca=M.IdMarca
	JOIN Sales.EstCom EC
		ON A.IdEstCom=EC.IdEstCom
	WHERE A.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)			
	)


