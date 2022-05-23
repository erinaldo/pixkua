-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Obtiene una lista de búsqueda de Productos
-- =============================================
CREATE FUNCTION [Production].[fxProductosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdProducto,P.Nombre As Producto,Cantidad,UM.Nombre AS [Unidad Medida],
		CASE P.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Production.Productos P
	INNER JOIN Inventory.UnidadesMedida UM ON UM.IdUnidadMedida=P.IdUnidadMedida
	WHERE P.IdSucursal=@IdSucursal
	)


