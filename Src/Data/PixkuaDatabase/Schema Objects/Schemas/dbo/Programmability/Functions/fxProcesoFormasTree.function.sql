-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 01-Jun-2006
-- Description:	Obtiene la lista de formas
-- =============================================
CREATE  FUNCTION [dbo].[fxProcesoFormasTree]()
RETURNS TABLE
AS
RETURN (
	SELECT PF.IdProcesoForma, PF.IdProceso, PF.Forma, Inicial
	FROM ProcesosFormas PF
	WHERE PF.IdStatus=1
		)


