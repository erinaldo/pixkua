CREATE FUNCTION [Accounting].[fxCFDSerieFoliosSEL](@IdCFDSerie as int)
RETURNS TABLE
AS
RETURN	(
	SELECT Fecha, NumAprobacion, AnioAprobacion, FolioInicial, FolioFinal
	FROM Accounting.CFDFolios
	WHERE IdCFDSerie=@IdCFDSerie
		)


