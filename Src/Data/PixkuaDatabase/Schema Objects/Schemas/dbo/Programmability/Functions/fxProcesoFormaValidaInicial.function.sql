CREATE FUNCTION [dbo].[fxProcesoFormaValidaInicial](@IdProcesoForma AS int, @IdProceso AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit
	DECLARE @Cant AS int

	SELECT @Cant=Count(IdProcesoForma)
	FROM ProcesosFormas	
	WHERE IdProceso=@IdProceso
	AND IdProcesoForma <> @IdProcesoForma

	IF @Cant > 1
		SET @Result=0
	ELSE
		SET @Result=1

	RETURN @Result
END


