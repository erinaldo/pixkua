-- =============================================
-- Author: alex Lopez
-- Create date: 13-oct-2010
-- Description:	Obtiene una lista de búsqueda de Entidades
-- =============================================
CREATE FUNCTION [Accounting].[fxEntidadesLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdEntidad,Entidad,
		CASE IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Accounting.Entidades
	WHERE IdSucursal=@IdSucursal
	)


