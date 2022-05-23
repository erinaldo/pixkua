-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene una lista de búsqueda de Puestos
-- =============================================
CREATE FUNCTION [RH].[fxPuestosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdPuesto, Nombre, [NamedPath] AS Ruta,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM RH.Puestos
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


