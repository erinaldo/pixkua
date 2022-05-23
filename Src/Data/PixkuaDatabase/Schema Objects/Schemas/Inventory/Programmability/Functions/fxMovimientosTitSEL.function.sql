-- =============================================
-- Author: RCO
-- Create date: 07-dic-2010
-- Description:	Obtiene la información del MovimientosTit especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxMovimientosTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Inventory.MovimientosTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdMovimientoTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		AND Cancelacion=0
		)


