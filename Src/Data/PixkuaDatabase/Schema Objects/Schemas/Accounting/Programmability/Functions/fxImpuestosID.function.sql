-- =============================================
-- Author: RCO
-- ALTER  date: 09-sep-2010
-- Description:	Obtiene el ID de Impuestos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxImpuestosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdImpuesto
	FROM Accounting.Impuestos
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


