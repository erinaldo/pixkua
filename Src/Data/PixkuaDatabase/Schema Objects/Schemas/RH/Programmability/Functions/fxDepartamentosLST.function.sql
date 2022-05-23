-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene una lista de búsqueda de Departamentos
-- =============================================
CREATE FUNCTION [RH].[fxDepartamentosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdDepartamento, Nombre, NamedPath AS Ruta, Nivel,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM RH.Departamentos
	WHERE IdEmpresa=(SELECT IdEmpresa FROM dbo.Sucursales WHERE IdSucursal=@IdSucursal)
	)


