-- =============================================
-- Author: RCO
-- Create date: 04-sep-2010
-- Description:	Verifica la existencia de CFDCertificados
-- =============================================
CREATE FUNCTION [Accounting].[fxCFDCertificadosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCFDCertificado FROM Accounting.CFDCertificados WHERE IdCFDCertificado=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


