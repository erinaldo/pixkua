-- =============================================
-- Author: Victor Moreno
-- Create date: 23-nov-2016
-- Description:	Aplica el proceso de flujo de trabajo del MaestrosIng especificado.
-- =============================================
CREATE PROCEDURE Production.MaestrosIngWorkflow
	@ID AS Char(18),
	@IdStatus as int,
	@UserUpdate as int,
	@PCUpdate as varchar(32)
AS
	SET NOCOUNT ON
	
	UPDATE Production.MaestrosIng 
	SET IdStatus = @IdStatus ,UserUpdate =@UserUpdate,PCUpdate=@PCUpdate, LastUpdate = getdate()
	WHERE IdMaestroIng=@ID AND Fecha = dbo.fxDocumentDate(@Id)