-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Jun-2006
-- Description:	Quita una política del grupo
-- =============================================
CREATE PROCEDURE [dbo].[spGruposPoliticasDEL]
	@IdGrupo AS int,
	@IdPolitica AS int
AS
	DELETE GruposPoliticas
	WHERE IdGrupo=@IdGrupo AND IdPolitica=@IdPolitica


