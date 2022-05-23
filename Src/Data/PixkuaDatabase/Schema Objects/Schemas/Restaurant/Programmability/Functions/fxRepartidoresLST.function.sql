-- =============================================
-- Author: alez Lopez
-- Create date: 08-ago-2011
-- Description:	Obtiene una lista de búsqueda de Repartidores
-- =============================================
CREATE FUNCTION [Restaurant].[fxRepartidoresLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdRepartidor,U.Usuario,R.NombreCorto AS [Nombre Corto],P.Nombre + ' ' + P.ApellidoP+ ' ' + P.ApellidoM AS Repartidor,
		CASE R.IdStatus
			WHEN 1 THEN 'Activo'
			WHEN 0 THEN 'Inactivo'
		END AS Estatus
	FROM Restaurant.Repartidores R
	INNER JOIN Usuarios U ON U.IdUsuario=R.IdUsuario
	INNER JOIN Personas P ON P.IdPersona=U.IdPersona

	WHERE R.IdSucursal=@IdSucursal
	)


