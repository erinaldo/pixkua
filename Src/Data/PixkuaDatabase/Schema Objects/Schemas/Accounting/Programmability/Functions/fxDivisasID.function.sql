-- =============================================
-- Author: RCO
-- ALTER  date: 10-sep-2010
-- Description:	Obtiene el ID de Divisas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxDivisasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdDivisa
	FROM Accounting.Divisas
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


