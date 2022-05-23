-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Jun-2006
-- Description:	Aplica una política a un usuario
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarioPoliticasDEL]
	@IdPolitica AS int,
	@IdUsuario AS int,
	@IdSucursal AS int
AS
	DELETE AccesoPoliticas
	WHERE IdPolitica=@IdPolitica 
	AND IdUsuario=@IdUsuario AND IdSucursal=@IdSucursal


