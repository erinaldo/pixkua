-- =============================================
-- Author: RCO
-- Create date: 22-sep-2011
-- Description:	Obtiene una lista de búsqueda de DevolucionesCausas
-- =============================================
CREATE FUNCTION [Sales].[fxDevolucionesCausasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdDevolucionCausa, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.DevolucionesCausas
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


