-- =============================================
-- Author: Alejandro Lopez Cadena
-- ALTER  date: 20-sep-2007
-- Description:	Obtiene el ID de Cuentas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxCuentasID] 
	(@Codigo AS varchar(64) ,@IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCuenta
	FROM Accounting.Cuentas
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


