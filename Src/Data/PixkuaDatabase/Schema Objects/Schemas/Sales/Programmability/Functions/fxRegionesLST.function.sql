-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene una lista de búsqueda de Regiones
-- =============================================
CREATE FUNCTION [Sales].[fxRegionesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT IdRegion, Nombre, Codigo
	FROM Sales.Regiones
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)		
	)


