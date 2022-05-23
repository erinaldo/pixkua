-- =============================================
-- Author: RCO
-- ALTER  date: 03-sep-2010
-- Description:	Obtiene el ID de UnidadesNegocio en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Sales].[fxUnidadesNegocioID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdUnidadNegocio
	FROM Sales.UnidadesNegocio
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


