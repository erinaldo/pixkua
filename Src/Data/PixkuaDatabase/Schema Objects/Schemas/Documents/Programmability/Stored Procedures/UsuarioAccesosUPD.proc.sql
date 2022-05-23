CREATE PROCEDURE [Documents].[UsuarioAccesosUPD]
	@IdUsuario as int,
	@IdSucursal as int,
	@IdTipo as int,
	@IdStatus as int,
	@Aplicar as bit,
	@Cancelar as bit
AS
	SET NOCOUNT ON
	
	IF EXISTS (SELECT IdUsuario FROM Documents.AccesoUsuarios WHERE IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal AND IdTipo=@IdTipo AND IdStatus=@IdStatus)
		UPDATE Documents.AccesoUsuarios SET Aplicar=@Aplicar, Cancelar=@Cancelar
		WHERE IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal AND IdTipo=@IdTipo AND IdStatus=@IdStatus
	ELSE
		INSERT INTO Documents.AccesoUsuarios (IdUsuario, IdSucursal, IdTipo, IdStatus, Aplicar, Cancelar)
		VALUES (@IdUsuario, @IdSucursal, @IdTipo, @IdStatus, @Aplicar, @Cancelar)


