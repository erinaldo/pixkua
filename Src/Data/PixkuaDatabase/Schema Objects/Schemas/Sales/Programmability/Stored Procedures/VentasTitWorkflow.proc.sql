-- =============================================
-- Author: RCO
-- Create date: 06-sep-2010
-- Description:	Aplica el proceso de flujo de trabajo del VentasTit especificado.
-- =============================================
CREATE PROCEDURE [Sales].[VentasTitWorkflow]
	@ID AS Char(18),
	@FechaTrabajo as datetime,
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	DECLARE @Fecha as datetime
	SET @Fecha=Documents.fxDocumentDate(@Id)
		
	/*Actualizar etatus e información de log*/
	UPDATE Sales.VentasTit 
	SET IdStatus=@IdStatus, UserUpdate=@UserUpdate, PCUpdate=@PCUpdate, LastUpdate = getdate()
	WHERE IdVentaTit=@ID AND Fecha=@Fecha
	
	--Se genera una poliza contable siempre y cuando el documento esté configurado
	EXEC Accounting.Contabilizar @Id, @FechaTrabajo, @IdStatus, @PCUpdate, @UserUpdate


