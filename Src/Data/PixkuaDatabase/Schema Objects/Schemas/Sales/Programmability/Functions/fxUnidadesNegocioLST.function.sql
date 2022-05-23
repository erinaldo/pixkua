-- =============================================
-- Author: RCO
-- Create date: 03-sep-2010
-- Description:	Obtiene una lista de búsqueda de UnidadesNegocio
-- =============================================
CREATE FUNCTION [Sales].[fxUnidadesNegocioLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(
	SELECT UN.IdUnidadNegocio, UN.Nombre, P.Poblacion, S.Colonia, S.Calle, UN.Codigo,
		CASE UN.IdStatus
			WHEN 0 THEN 'Inactivo'
			WHEN 1 THEN 'Activo'
		END AS Estatus
	FROM Sales.UnidadesNegocio UN JOIN dbo.Sucursales S
		ON UN.IdSucursal=S.IdSucursal
	JOIN dbo.Poblaciones P
		ON S.IdPoblacion=P.IdPoblacion	
	)


