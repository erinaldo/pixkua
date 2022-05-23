CREATE FUNCTION [Accounting].[fxCFDSeriesCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdCFDSerie, Codigo, Serie
	FROM Accounting.CFDSeries
	WHERE IdEmpresa=@IdEmpresa AND IdStatus=1
		)


