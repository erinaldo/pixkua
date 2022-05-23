-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 01-Jun-2006
-- Description:	Obtiene la lista de políticas
-- =============================================
CREATE  FUNCTION [dbo].[fxPoliticasTree]()
RETURNS TABLE
AS
RETURN (
	SELECT P.IdPolitica, PF.IdProceso, PF.Forma, P.IdProcesoForma, P.Politica, P.Descripcion,
		CASE P.IdPoliticaTipo
			WHEN 1 THEN 'Intefase'
			WHEN 2 THEN 'Lógica'
		END AS Tipo,
		CASE P.Comportamiento
			WHEN 'T' THEN 'Aplicar a Todos'
			WHEN 'E' THEN 'Sólo a Específicos'
		END AS Comportamiento,
		CASE P.IdStatus
			WHEN 1 THEN 'Activa'
			WHEN 0 THEN 'Inactiva'
		END AS Estatus,
		P.Comportamiento AS IdComportamiento		
	FROM dbo.Politicas P JOIN dbo.ProcesosFormas PF
		ON P.IdProcesoForma=PF.IdProcesoForma
	WHERE P.IdStatus=1
		)


