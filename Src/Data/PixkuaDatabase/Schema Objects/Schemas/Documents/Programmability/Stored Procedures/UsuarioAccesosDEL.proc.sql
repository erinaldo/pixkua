CREATE PROCEDURE [Documents].[UsuarioAccesosDEL]
	@IdUsuario as int,
	@IdSucursal as int,
	@IdTipo as int,
	@IdStatus as int
AS
	DELETE Documents.AccesoUsuarios 
	WHERE IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal 
		AND IdTipo=@IdTipo AND IdStatus=@IdStatus


