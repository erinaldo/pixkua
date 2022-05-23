CREATE FUNCTION [Documents].[fxNextStatus](@IdTipo as int, @IdStatusActual as int)
RETURNS INT
AS
BEGIN
	DECLARE @IdStatusNext as Int

	SELECT @IdStatusNext=WN.IdStatus
	FROM Documents.Workflow W
	INNER JOIN Documents.Workflow WN 
		ON WN.IdDocumentoTipo=W.IdDocumentoTipo AND WN.Secuencia > W.Secuencia
	WHERE W.IdDocumentoTipo=@IdTipo AND W.IdStatus=@IdStatusActual 
	ORDER BY WN.Secuencia desc

	SET @IdStatusNext= IsNull(@IdStatusNext,0)

	RETURN @IdStatusNext
END


