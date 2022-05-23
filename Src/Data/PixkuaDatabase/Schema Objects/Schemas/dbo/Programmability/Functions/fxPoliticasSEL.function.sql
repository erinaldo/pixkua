-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 10-Jun-2006
-- Description:	Obtiene la información de la política de seguridad especificada.
-- =============================================
CREATE FUNCTION [dbo].[fxPoliticasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT P.*, IdPolitica AS Codigo, PF.Forma, PF.Namespace + '.' + PF.Clase AS ClaseForma
	FROM dbo.Politicas P JOIN ProcesosFormas PF ON P.IdProcesoForma=PF.IdProcesoForma
	WHERE P.IdPolitica=@ID)


