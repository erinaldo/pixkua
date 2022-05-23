-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene una lista de búsqueda de ZonasVenta
-- =============================================
CREATE FUNCTION [Sales].[fxZonasVentaLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdZonaVenta, Nombre, Codigo,
		CASE IdStatus
			WHEN 0 THEN 'Inactivo'
			WHEN 1 THEN 'Activo'
		END AS Estatus
	FROM Sales.ZonasVenta
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)		
	)


