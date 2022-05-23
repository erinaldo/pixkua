-- =============================================
-- Author: alex Lopez
-- Create date: 08-nov-2010
-- Description:	Aplica el proceso de flujo de trabajo del PolizasTit especificado.
-- =============================================
CREATE PROCEDURE [Accounting].[PolizasTitWorkflow]
	@ID AS Char(18),
	@IdStatus as int,
	@FechaTrabajo as datetime,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	UPDATE Accounting.PolizasTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate=getdate()
	WHERE IdPolizaTit=@ID AND Fecha = Documents.fxDocumentDate(@Id)


