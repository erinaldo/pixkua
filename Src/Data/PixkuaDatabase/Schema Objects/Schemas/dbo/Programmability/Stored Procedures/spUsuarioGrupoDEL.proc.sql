-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 30-May-2006
-- Description:	Elimina un usuario del grupo de usuarios
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarioGrupoDEL]
	@IdUsuario AS int,
	@IdGrupo AS int
AS
	DELETE UsuariosGrupos
	WHERE IdUsuario=@IdUsuario AND IdGrupo=@IdGrupo


