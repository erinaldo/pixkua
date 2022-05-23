-- =============================================
-- Author: RCO
-- Create date: 02-nov-2011
-- Description:	Obtiene una lista de búsqueda de Servicios
-- =============================================
CREATE FUNCTION [Purchasing].[fxServiciosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdServicio, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Purchasing.Servicios
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


