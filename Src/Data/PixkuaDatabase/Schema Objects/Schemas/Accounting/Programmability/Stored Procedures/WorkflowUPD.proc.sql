CREATE PROCEDURE [Accounting].[WorkflowUPD]
	@IdDocumentoTipo AS int,
	@IdStatus AS int,
	@Secuencia AS int
AS
	SET NOCOUNT ON
			
	INSERT INTO Documents.Workflow(IdDocumentoTipo,IdStatus,Secuencia)
	VALUES (@IdDocumentoTipo, @IdStatus, @Secuencia)
	--TODO: Falta implementar la actualización de las columnas UserCreate y CreateDate


