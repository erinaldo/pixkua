-- =============================================
-- Author: Ricardo Cortés Ornelas
-- Create date: 31-Dic-2005
-- Description:	Verifica la existencia de un proceso
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdProceso FROM dbo.Procesos WHERE IdProceso=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


