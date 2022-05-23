-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-DIC-2005
-- Devuelve un listado de usuarios para realizar búsquedas.
-- =============================================

CREATE   FUNCTION [dbo].[fxUsuariosLST](@IdUsuario AS int, @IdSucursal AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT IdUsuario, Usuario, P.ApellidoP + ' ' + P.ApellidoM AS Apellidos,
		P.Nombre, P.Correo
	FROM dbo.Usuarios U JOIN Personas P 
		ON U.IdPersona=P.IdPersona
	)


