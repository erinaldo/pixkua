-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene una lista de búsqueda de Servicios
-- =============================================
CREATE FUNCTION [Sales].[fxServiciosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT S.IdServicio, S.Nombre, S.ConceptoLibre AS [Concepto Libre], EC.NamedPath [Est. Comercial], S.Codigo,  
		CASE S.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Sales.Servicios S JOIN Sales.EstCom EC
		ON S.IdEstCom=EC.IdEstCom
	WHERE S.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)		
	)


