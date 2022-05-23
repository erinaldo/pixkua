-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Jun-2006
-- Description:	Da acceso a un grupo a un nuevo proceso 
-- =============================================
CREATE PROCEDURE [dbo].[spGruposProcesosINS]
	@IdGrupo AS int,
	@IdProceso AS int
AS
	INSERT INTO GruposProcesos(IdGrupo, IdProceso)
	VALUES (@IdGrupo, @IdProceso)


