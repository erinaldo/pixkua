-- =============================================
-- Author: RCO
-- ALTER  date: 20-sep-2010
-- Description:	Obtiene el ID de Paises en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxPaisesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdPais
	FROM dbo.Paises
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


