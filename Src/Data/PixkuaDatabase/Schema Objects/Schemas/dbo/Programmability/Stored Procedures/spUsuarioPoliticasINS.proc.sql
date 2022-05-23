-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Jun-2006
-- Description:	Aplica una política a un usuario
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarioPoliticasINS]
	@IdPolitica AS int,
	@IdUsuario AS int,
	@IdSucursal AS int
AS
	INSERT INTO AccesoPoliticas (IdPolitica, IdUsuario, IdSucursal)
	VALUES (@IdPolitica, @IdUsuario, @IdSucursal)


