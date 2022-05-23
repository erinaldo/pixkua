-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Aplica el proceso de flujo de trabajo del ComandaTit especificado.
-- =============================================
CREATE PROCEDURE [Restaurant].[ComandaTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON

	EXEC Accounting.Contabilizar   @Id,@FechaTrabajo,@IdStatus,@PCUpdate,@UserUpdate,0
	
	UPDATE Restaurant.ComandaTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdComandaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


