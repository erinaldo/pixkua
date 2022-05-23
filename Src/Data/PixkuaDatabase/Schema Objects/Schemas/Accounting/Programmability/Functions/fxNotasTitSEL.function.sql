-- =============================================
-- Author: RCO
-- Create date: 04-abr-2011
-- Description:	Obtiene la información del NotasTit especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxNotasTitSEL](@ID AS char(18), @IdUsuario AS int)
RETURNS TABLE
AS
RETURN	(
	SELECT T.*, IsNull(Se.Serie,'') AS SerieNota, S.[Status] as [Status]
	FROM Accounting.NotasTit  AS T INNER JOIN Documents.[Status] AS S 
		ON S.IdStatus=T.IdStatus
	LEFT JOIN Accounting.CFDSeries Se
		ON T.IdCFDSerie=Se.IdCFDSerie
	WHERE IdNotaTit=@ID and Fecha = Documents.fxDocumentDate(@Id)
		)


