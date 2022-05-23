-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 03-Jun-2006
-- Description:	Obtiene las políticas que aplican para el grupo especificado
-- =============================================
CREATE FUNCTION [dbo].[fxGrupoPoliticasSEL](@IdGrupo AS int)
RETURNS TABLE
AS
RETURN (
		SELECT GP.IdPolitica 
		FROM GruposPoliticas GP 
		WHERE GP.IdGrupo=@IdGrupo		
		)


