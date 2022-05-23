-- =============================================
-- Author: RCO
-- ALTER  date: 06-sep-2010
-- Description:	Obtiene el ID de CFDAddendas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxCFDAddendasID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdCFDAddenda
	FROM Accounting.CFDAddendas
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


