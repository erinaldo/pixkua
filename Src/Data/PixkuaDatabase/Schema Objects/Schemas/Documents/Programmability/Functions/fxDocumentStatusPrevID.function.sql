CREATE FUNCTION [Documents].[fxDocumentStatusPrevID] 
	(@IdDocumentoTipo as int,@IdStatusActual as int)
RETURNS int
AS
BEGIN
	DECLARE @Result as int, @Secuencia as int
	--Obtener secuencia actual del tipo de documento y estatus

	SELECT @Secuencia=Secuencia
	FROM Documents.Workflow
	WHERE IdDocumentoTipo=@IdDocumentoTipo AND IdStatus=@IdStatusActual

	
	SELECT @Result=IdStatus
	FROM Documents.Workflow
	WHERE IdDocumentoTipo=@IdDocumentoTipo AND Secuencia=@Secuencia - 1

	RETURN IsNull(@Result, 2) --Si no encuentra el previo, ponemos el de cancelar
END


