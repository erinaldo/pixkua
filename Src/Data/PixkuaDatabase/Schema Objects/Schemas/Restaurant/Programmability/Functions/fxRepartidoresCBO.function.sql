-- =============================================
-- Author: alez Lopez
-- Create date: 08-ago-2011
-- Description:	Obtiene una lista de búsqueda de Repartidores
-- =============================================
CREATE FUNCTION [Restaurant].[fxRepartidoresCBO]( @IdSucursal AS int)
RETURNS TABLE
AS
RETURN
	(
	SELECT IdRepartidor,R.Codigo,U.Usuario,R.NombreCorto AS [Nombre Corto],P.Nombre + ' ' + P.ApellidoP+ ' ' + P.ApellidoM AS Repartidor
	FROM Restaurant.Repartidores R
	INNER JOIN Usuarios U ON U.IdUsuario=R.IdUsuario
	INNER JOIN Personas P ON P.IdPersona=U.IdPersona
	WHERE R.IdSucursal=@IdSucursal
	)


