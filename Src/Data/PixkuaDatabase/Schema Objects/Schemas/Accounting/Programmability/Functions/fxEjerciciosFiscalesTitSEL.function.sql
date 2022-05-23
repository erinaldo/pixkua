-- =============================================
-- Author: alez Lopez
-- Create date: 13-sep-2011
-- Description:	Obtiene la información del EjerciciosFiscalesTit especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxEjerciciosFiscalesTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, S.[Status] as [Status]
	FROM Accounting.EjerciciosFiscalesTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	WHERE IdEjercicioFiscalTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


