CREATE PROCEDURE [Documents].[UsuarioAccesosINS]
	@IdUsuario as int,
	@IdSucursal as int,
	@IdTipo as int,
	@IdStatus as int,
	@Aplicar as bit,
	@Cancelar as bit
AS
	SET NOCOUNT ON

	INSERT INTO Documents.AccesoUsuarios (IdUsuario, IdSucursal, IdTipo, IdStatus, Aplicar, Cancelar)
	VALUES (@IdUsuario, @IdSucursal, @IdTipo, @IdStatus, @Aplicar, @Cancelar)


