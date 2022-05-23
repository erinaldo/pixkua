-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Devuelve un listado de sucursales para realizar búsquedas.
-- =============================================

CREATE  FUNCTION [dbo].[fxSucursalesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdSucursal, Nombre, NombreLargo AS [Nombre Largo], Codigo
	FROM dbo.Sucursales)


