-- =============================================
-- Author: alex Lopez
-- ALTER  date: 10-ene-2011
-- Description:	Obtiene el ID de SegmentosNegocio en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxSegmentosNegocioID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdSegmentoNegocio
	FROM Accounting.SegmentosNegocio
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


