-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 30-DIC-2005
-- Description:	Elimina el usuario especificado.
-- =============================================
CREATE  PROCEDURE [dbo].[UsuariosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE dbo.Usuarios WHERE IdUsuario=@ID


