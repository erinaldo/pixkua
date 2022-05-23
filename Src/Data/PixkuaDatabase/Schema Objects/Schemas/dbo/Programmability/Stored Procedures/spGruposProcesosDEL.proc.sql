-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Jun-2006
-- Description:	Elimina el acceso de un grupo a un proceso 
-- =============================================
CREATE PROCEDURE [dbo].[spGruposProcesosDEL]
	@IdGrupo AS int,
	@IdProceso AS int
AS
	DELETE GruposProcesos
	WHERE IdGrupo=@IdGrupo AND IdProceso=@IdProceso


