-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Obtiene una lista de búsqueda de Meseros
-- =============================================
CREATE FUNCTION [Restaurant].[fxMeserosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdMesero,U.Usuario,M.NombreCorto AS [Nombre Corto],P.Nombre + ' ' + P.ApellidoP+ ' ' + P.ApellidoM AS Mesero,
		CASE M.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Restaurant.Meseros M
	INNER JOIN Usuarios U ON U.IdUsuario=M.IdUsuario
	INNER JOIN Personas P ON P.IdPersona=U.IdPersona
	WHERE M.IdSucursal=@IdSucursal
	)


