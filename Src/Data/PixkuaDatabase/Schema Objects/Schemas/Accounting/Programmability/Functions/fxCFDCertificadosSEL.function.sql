-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Obtiene la información del CFDCertificados especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDCertificadosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.CFDCertificados WHERE IdCFDCertificado=@ID)


