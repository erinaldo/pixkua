-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 01-Jun-2006
-- Description:	Agrega o quita el acceso de un usuario a una sucursal
-- =============================================
CREATE  PROCEDURE [dbo].[spUsuarioSucursalUPD]
	@IdUsuario AS int,
	@IdSucursal AS int,
	@Acceso AS bit
AS
IF @Acceso=1
	INSERT INTO UsuariosSucursales (IdUsuario, IdSucursal)
	VALUES (@IdUsuario, @IdSucursal)
ELSE
BEGIN
	DELETE UsuariosSucursales 
	WHERE IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal
	--Eliminar accesos a políticas y procesos de esa sucursal
	DELETE AccesoProcesos WHERE IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal
	DELETE AccesoPoliticas WHERE IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal
END


