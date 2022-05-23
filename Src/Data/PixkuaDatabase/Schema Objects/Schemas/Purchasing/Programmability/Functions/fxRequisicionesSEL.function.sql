-- =============================================
-- Author: alex lopez
-- Create date: 07-nov-2011
-- Description:	Obtiene la información del Requisiciones especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxRequisicionesSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Purchasing.Requisiciones  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdRequisicion=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


