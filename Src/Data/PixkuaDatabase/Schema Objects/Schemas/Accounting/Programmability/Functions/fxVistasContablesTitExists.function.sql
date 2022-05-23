-- =============================================
-- Author: alez lopez
-- Create date: 17-oct-2010
-- Description:	Verifica la existencia de VistasContablesTit
-- =============================================
CREATE FUNCTION [Accounting].[fxVistasContablesTitExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdVistaContableTit FROM Accounting.VistasContablesTit WHERE IdVistaContableTit=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


