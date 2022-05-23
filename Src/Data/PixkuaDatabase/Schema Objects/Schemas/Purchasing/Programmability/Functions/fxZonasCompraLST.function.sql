-- =============================================
-- Author: RCO
-- Create date: 01-nov-2011
-- Description:	Obtiene una lista de búsqueda de ZonasCompra
-- =============================================
CREATE FUNCTION [Purchasing].[fxZonasCompraLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdZonaCompra, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.ZonasCompra
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


