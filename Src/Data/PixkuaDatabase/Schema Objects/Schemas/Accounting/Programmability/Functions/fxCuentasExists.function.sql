-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Verifica la existencia de Cuentas
-- =============================================
CREATE FUNCTION [Accounting].[fxCuentasExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdCuenta FROM Accounting.Cuentas WHERE IdCuenta=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


