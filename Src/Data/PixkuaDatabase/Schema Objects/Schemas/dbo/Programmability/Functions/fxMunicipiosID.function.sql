-- =============================================
-- Author: RCO
-- ALTER  date: 23-mar-2009
-- Description:	Obtiene el ID de Municipios en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxMunicipiosID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdMunicipio
	FROM dbo.Municipios
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


