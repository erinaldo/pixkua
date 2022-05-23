CREATE FUNCTION [Accounting].[fxCFDCertificadosCBO](@IdEmpresa as int)
RETURNS TABLE
AS
RETURN	(
	SELECT IdCFDCertificado, Codigo, Nombre 
	FROM Accounting.CFDCertificados
	WHERE IdStatus=1 AND IdEmpresa=@IdEmpresa
		)


