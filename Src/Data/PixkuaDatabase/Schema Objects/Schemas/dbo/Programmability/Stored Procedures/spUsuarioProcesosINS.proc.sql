-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Jun-2006
-- Description:	Agrega un nuevo acceso para un usuario
-- =============================================
CREATE PROCEDURE [dbo].[spUsuarioProcesosINS]
	@IdProceso AS int,
	@IdUsuario AS int,
	@IdSucursal AS int
AS
	INSERT INTO AccesoProcesos(IdProceso, IdUsuario, IdSucursal)
	VALUES (@IdProceso, @IdUsuario, @IdSucursal)


