CREATE PROCEDURE [Accounting].[ContabilizacionCombinacionesUPD]
@IdContabilizacionCombinacion as int out,
@IdContabilizacionDocumentoDet as int,
@IdEntidad as int,
@Sel as bit
AS

	IF @IdContabilizacionCombinacion=0 AND @IdEntidad>0
	BEGIN
		INSERT INTO Accounting.ContabilizacionCombinaciones(IdContabilizacionDocumentoDet,IdEntidad)VALUES(@IdContabilizacionDocumentoDet,@IdEntidad)
		SET @IdContabilizacionCombinacion=@@IDENTITY
	END
	ELSE
		IF @IdContabilizacionCombinacion>0 AND (@IdEntidad=0 OR @Sel=0)
			DELETE Accounting.ContabilizacionCombinaciones WHERE IdContabilizacionCombinacion=@IdContabilizacionCombinacion
		ELSE
			UPDATE Accounting.ContabilizacionCombinaciones SET IdEntidad=@IdEntidad WHERE IdContabilizacionCombinacion=@IdContabilizacionCombinacion


