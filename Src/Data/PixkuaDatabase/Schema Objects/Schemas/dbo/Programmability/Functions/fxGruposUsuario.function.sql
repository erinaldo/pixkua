-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-May-2006
-- Description:	Obtiene la lista de grupos a los que pertenece un usuario.
-- =============================================
CREATE FUNCTION [dbo].[fxGruposUsuario](@IdUsuario AS int)
RETURNS TABLE
AS
RETURN (
	SELECT UG.IdGrupo, G.Codigo, G.Grupo
	FROM GruposUsr G JOIN UsuariosGrupos UG
		ON G.IdGrupo=UG.IdGrupo
	WHERE UG.IdUsuario=@IdUsuario
	)


