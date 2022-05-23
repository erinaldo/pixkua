-- =============================================
-- Author: Victor Moreno
-- Create date: 23-nov-2016
-- Description:	Elimina el MaestrosIng especificado.
-- =============================================
CREATE PROCEDURE Production.MaestrosIngDEL
	@ID AS Char(18)
AS
	SET NOCOUNT ON
	
	DELETE Production.MaestrosIng WHERE IdMaestroIng=@ID AND Fecha = dbo.fxDocumentDate(@Id)