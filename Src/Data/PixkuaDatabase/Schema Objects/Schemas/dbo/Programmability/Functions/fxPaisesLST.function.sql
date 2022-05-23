-- =============================================
-- Author: RCO
-- Create date: 20-sep-2010
-- Description:	Obtiene una lista de búsqueda de Paises
-- =============================================
CREATE FUNCTION [dbo].[fxPaisesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdPais, Pais, Codigo,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM dbo.Paises
	)


