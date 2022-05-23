CREATE FUNCTION [dbo].[fxProcesosFormasCBO](@IdProceso as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdProcesoForma, Forma 
	FROM dbo.ProcesosFormas
	WHERE IdProceso=@IdProceso
		)


