-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 02-Jun-2006
-- Description:	Obtiene las políticas que aplican para el usuario especificado
-- =============================================
CREATE  FUNCTION [dbo].[fxUsuarioPoliticas](@IdUsuario AS int)
RETURNS TABLE
AS
RETURN (
		SELECT IdSucursal, IdPolitica 
		FROM AccesoPoliticas
		WHERE IdUsuario=@IdUsuario
		
		UNION
		
		SELECT US.IdSucursal, GP.IdPolitica 
		FROM GruposPoliticas GP JOIN UsuariosGrupos UG
			ON GP.IdGrupo=UG.IdGrupo
		JOIN UsuariosSucursales US 
			ON UG.IdUsuario=US.IdUsuario
		WHERE UG.IdUsuario=@IdUsuario
						
		)


