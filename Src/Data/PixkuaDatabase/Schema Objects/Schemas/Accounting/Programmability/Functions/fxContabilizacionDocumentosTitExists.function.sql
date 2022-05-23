-- =============================================
-- Author: alexLopez
-- Create date: 15-oct-2010
-- Description:	Verifica la existencia de ContabilizacionDocumentosTit
-- =============================================
CREATE FUNCTION [Accounting].[fxContabilizacionDocumentosTitExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdContabilizacionDocumentoTit FROM Accounting.ContabilizacionDocumentosTit WHERE IdContabilizacionDocumentoTit=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


