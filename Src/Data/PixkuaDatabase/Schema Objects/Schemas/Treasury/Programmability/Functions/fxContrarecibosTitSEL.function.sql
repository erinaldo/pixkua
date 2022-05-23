-- =============================================
-- Author: alex Lopez
-- Create date: 29-nov-2011
-- Description:	Obtiene la información del ContrarecibosTit especificado.
-- =============================================
CREATE FUNCTION [Treasury].[fxContrarecibosTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Treasury.ContrarecibosTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdContrareciboTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


