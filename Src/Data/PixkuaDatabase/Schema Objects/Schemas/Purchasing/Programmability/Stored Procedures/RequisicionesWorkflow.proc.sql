-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Aplica el proceso de flujo de trabajo del Requisiciones especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[RequisicionesWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as Datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.Requisiciones 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdRequisicion=@ID AND Fecha = Documents.fxDocumentDate(@Id)

	--Se genera una poliza contable siempre y cuando el documento esté configurado
	EXEC Accounting.Contabilizar @Id, @FechaTrabajo,@IdStatus,@PCUpdate,@UserUpdate


