CREATE FUNCTION [dbo].[fxProcesoFormasSEL](@IdProceso AS int)
RETURNS TABLE
AS
RETURN
	(SELECT * FROM ProcesosFormas
	WHERE IdProceso=@IdProceso)


