-- =============================================
-- Author: alex Lopez
-- ALTER  date: 09-oct-2010
-- Description:	Obtiene el ID de Polizas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxPolizasPerfilesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdPolizaPerfil
	FROM Accounting.PolizasPerfiles
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


