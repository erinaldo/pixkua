-- =============================================
-- Author: alex opez
-- ALTER  date: 13-oct-2010
-- Description:	Obtiene el ID de Tipos en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Documents].[fxTiposID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdDocumentoTipo
	FROM Documents.Tipos
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


