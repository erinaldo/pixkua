-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 31-May-2006
-- Description:	Obtiene la lista de usuarios miembros del grupo.
-- =============================================
CREATE  FUNCTION [dbo].[fxUsuariosGrupo](@IdGrupo AS int)
RETURNS TABLE
AS
RETURN (
	SELECT UG.IdUsuario, U.Usuario, P.ApellidoP + ' ' + P.ApellidoM + ' ' + P.Nombre AS Nombre
	FROM UsuariosGrupos UG JOIN Usuarios U ON UG.IdUsuario=U.IdUsuario
	JOIN Personas P ON U.IdPersona=P.IdPersona
	WHERE UG.IdGrupo=@IdGrupo
		)


