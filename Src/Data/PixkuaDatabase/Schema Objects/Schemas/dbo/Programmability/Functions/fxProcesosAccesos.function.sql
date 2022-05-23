-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 02-Jun-2006
-- Description:	Obtiene los accesos a procesos de un usuario
-- =============================================
CREATE  FUNCTION [dbo].[fxProcesosAccesos] (@IdUsuario AS int)
RETURNS TABLE
AS
RETURN (
	SELECT IdSucursal, IdProceso
	FROM dbo.AccesoProcesos A 
	WHERE A.IdUsuario=@IdUsuario
	UNION
	SELECT US.IdSucursal, GP.IdProceso
	FROM dbo.GruposProcesos GP JOIN dbo.UsuariosGrupos UG
		ON GP.IdGrupo=UG.IdGrupo
	JOIN UsuariosSucursales US 
		ON UG.IdUsuario=US.IdUsuario
	WHERE UG.IdUsuario=@IdUsuario
		)


