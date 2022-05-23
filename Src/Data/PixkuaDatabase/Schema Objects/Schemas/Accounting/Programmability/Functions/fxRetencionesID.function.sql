-- =============================================
-- Author: alex Lopez
-- ALTER  date: 24-nov-2011
-- Description:	Obtiene el ID de Retenciones en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxRetencionesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdRetencion
	FROM Accounting.Retenciones
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


