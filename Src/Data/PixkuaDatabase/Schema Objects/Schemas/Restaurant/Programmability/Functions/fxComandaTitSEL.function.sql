-- =============================================
-- Author: alez Lopez
-- Create date: 11-feb-2011
-- Description:	Obtiene la información del ComandaTit especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxComandaTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Restaurant.ComandaTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdComandaTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


