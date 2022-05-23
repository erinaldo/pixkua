-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Jun-2006
-- Description:	Elimina el acceso a un proceso
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarioProcesosDEL]
	@IdProceso AS int,
	@IdUsuario AS int,
	@IdSucursal AS int
AS
	DELETE AccesoProcesos
	WHERE IdProceso=@IdProceso 
		AND IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal


