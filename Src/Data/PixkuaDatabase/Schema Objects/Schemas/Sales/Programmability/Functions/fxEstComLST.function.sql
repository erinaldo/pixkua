-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene una lista de búsqueda de EstCom
-- =============================================
CREATE FUNCTION [Sales].[fxEstComLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdEstCom, Nombre, NamedPath AS [Ruta], Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.EstCom
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)		
	)


