-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Aplica el proceso de flujo de trabajo del ContrarecibosTit especificado.
-- =============================================
CREATE PROCEDURE [Treasury].[ContrarecibosTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as Datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	
	UPDATE Treasury.ContrarecibosTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdContrareciboTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)

	--Se genera una poliza contable siempre y cuando el documento esté configurado
	EXEC Accounting.Contabilizar @Id, @FechaTrabajo,@IdStatus,@PCUpdate,@UserUpdate


