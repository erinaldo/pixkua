-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-May-2006
-- Description:	Agrega un usuario a un Grupo de usuarios.
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarioGrupoINS]
	@IdUsuario AS int,
	@IdGrupo AS int
AS
	IF NOT Exists(SELECT IdUsuario FROM UsuariosGrupos 
	WHERE IdUsuario=@IdUsuario AND IdGrupo=@IdGrupo)

		INSERT INTO UsuariosGrupos(IdUsuario, IdGrupo)
		VALUES (@IdUsuario, @IdGrupo)


