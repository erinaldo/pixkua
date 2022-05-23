-- =============================================
-- Author: RCO
-- Create date: 26-jun-2011
-- Description:	Obtiene la información del TraspasosTit especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxTraspasosTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Inventory.TraspasosTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdTraspasoTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


