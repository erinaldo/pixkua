-- =============================================
-- Author: RCO
-- Create date: 02-dic-2011
-- Description:	Obtiene la información del OrdenesTit especificado.
-- =============================================
CREATE FUNCTION [Purchasing].[fxOrdenesTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Purchasing.OrdenesTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdOrdenTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


