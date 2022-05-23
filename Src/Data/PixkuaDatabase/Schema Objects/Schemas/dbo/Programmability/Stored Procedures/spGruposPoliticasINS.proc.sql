-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Jun-2006
-- Description:	Aplica una nueva política a un grupo
-- =============================================
CREATE PROCEDURE [dbo].[spGruposPoliticasINS]
	@IdGrupo AS int,
	@IdPolitica AS int
AS
	INSERT INTO GruposPoliticas (IdGrupo, IdPolitica)
	VALUES (@IdGrupo, @IdPolitica)


