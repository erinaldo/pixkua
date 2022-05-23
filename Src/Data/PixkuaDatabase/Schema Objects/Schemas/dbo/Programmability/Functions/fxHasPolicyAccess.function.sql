CREATE FUNCTION [dbo].[fxHasPolicyAccess](@IdPolitica as int, @IdUsuario as int, @IdSucursal as int)
RETURNS BIT
AS
BEGIN
	DECLARE @Result AS bit

IF EXISTS(
	SELECT IdPolitica 
	FROM AccesoPoliticas
	WHERE IdUsuario=@IdUsuario AND IdPolitica=@IdPolitica AND IdSucursal=@IdSucursal
	UNION ALL
	SELECT GP.IdPolitica 
	FROM GruposPoliticas GP JOIN UsuariosGrupos UG
		ON GP.IdGrupo=UG.IdGrupo
	JOIN UsuariosSucursales US 
		ON UG.IdUsuario=US.IdUsuario
	WHERE UG.IdUsuario=@IdUsuario AND GP.IdPolitica=@IdPolitica AND US.IdSucursal=@IdSucursal
		)
	SET @Result=1
ELSE
	SET @Result=0

	RETURN @Result
END


