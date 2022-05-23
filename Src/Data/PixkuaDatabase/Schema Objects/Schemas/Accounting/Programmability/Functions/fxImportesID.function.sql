-- =============================================
-- Author: alez Lopez
-- ALTER  date: 18-oct-2010
-- Description:	Obtiene el ID de Importes en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxImportesID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdImporte
	FROM Accounting.Importes
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


