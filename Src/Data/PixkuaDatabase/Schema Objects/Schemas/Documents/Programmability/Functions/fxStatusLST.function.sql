-- =============================================
-- Author: alex Lopez
-- Create date: 14-oct-2010
-- Description:	Obtiene una lista de búsqueda de Status
-- =============================================
CREATE FUNCTION [Documents].[fxStatusLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdStatus,Status AS Nombre,StatusApplied AS Aplicado,
		CASE Activo
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Documents.Status
	)


