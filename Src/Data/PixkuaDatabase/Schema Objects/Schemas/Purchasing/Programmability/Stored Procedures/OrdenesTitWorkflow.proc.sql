-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Aplica el proceso de flujo de trabajo del OrdenesTit especificado.
-- =============================================
CREATE PROCEDURE [Purchasing].[OrdenesTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as Datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	UPDATE Purchasing.OrdenesTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdOrdenTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)

	--Se genera una poliza contable siempre y cuando el documento esté configurado
	EXEC Accounting.Contabilizar @Id, @FechaTrabajo,@IdStatus,@PCUpdate,@UserUpdate


