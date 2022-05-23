-- =============================================
-- Author: RCO
-- Create date: 15-oct-2010
-- Description:	Obtiene una lista de búsqueda de Marcas
-- =============================================
CREATE FUNCTION [Sales].[fxMarcasLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdMarca, Nombre, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Marcas
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)	
	)


