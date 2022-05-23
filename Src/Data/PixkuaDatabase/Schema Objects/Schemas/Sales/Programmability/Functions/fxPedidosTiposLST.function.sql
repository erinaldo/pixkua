-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene una lista de búsqueda de PedidosTipos
-- =============================================
CREATE FUNCTION [Sales].[fxPedidosTiposLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdPedidoTipo, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.PedidosTipos
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


