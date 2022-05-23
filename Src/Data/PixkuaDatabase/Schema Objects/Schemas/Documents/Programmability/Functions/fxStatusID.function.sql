-- =============================================
-- Author: alex Lopez
-- ALTER  date: 14-oct-2010
-- Description:	Obtiene el ID de Status en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Documents].[fxStatusID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdStatus
	FROM Documents.Status
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


