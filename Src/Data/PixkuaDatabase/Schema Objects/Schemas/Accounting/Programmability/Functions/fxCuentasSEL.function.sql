-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Obtiene la información del Cuentas especificado.
-- =============================================
CREATE FUNCTION [Accounting].[fxCuentasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Accounting.Cuentas WHERE IdCuenta=@ID)


