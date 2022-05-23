-- =============================================
-- Author: Victor Moreno
-- Create date: 23-nov-2016
-- Description:	Obtiene la información del MaestrosIng especificado.
-- =============================================
CREATE FUNCTION Production.fxMaestrosIngSEL(@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.Status as Status 
	FROM Production.MaestrosIng  AS T
	INNER JOIN Documents.Status AS S ON S.IdStatus=T.IdStatus
	WHERE IdMaestroIng=@ID and Fecha = dbo.fxDocumentDate(@Id)
		)