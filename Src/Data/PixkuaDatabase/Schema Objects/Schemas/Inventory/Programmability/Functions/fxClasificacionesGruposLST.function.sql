-- =============================================
-- Author: RCO
-- Create date: 30-jun-2011
-- Description:	Obtiene una lista de búsqueda de ClasificacionesGrupos
-- =============================================
CREATE FUNCTION [Inventory].[fxClasificacionesGruposLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT CG.IdClasificacionGrupo, CG.Nombre, CE.Nombre AS Entidad, CG.Codigo,
		CASE CG.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Inventory.ClasificacionesGrupos CG JOIN Inventory.ClasificacionesEntidades CE
		ON CG.IdClasificacionEntidad=CE.IdClasificacionEntidad		
	WHERE CG.IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


