-- =============================================
-- Author: RCO
-- ALTER  date: 08-sep-2010
-- Description:	Obtiene el ID de FormasPago en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxFormasPagoID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdFormaPago
	FROM Sales.FormasPago
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


