-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 26-Mar-2006
-- Description:	Verifica la existencia de la forma especificada
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosFormasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdProcesoForma FROM dbo.ProcesosFormas WHERE IdProcesoForma=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


