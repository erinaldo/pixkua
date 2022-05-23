-- =============================================
-- Author: alexLopez
-- ALTER  date: 15-oct-2010
-- Description:	Obtiene el ID de ContabilizacionDocumentosTit en base a su código de usuario.
-- =============================================

CREATE FUNCTION [Accounting].[fxContabilizacionDocumentosTitID] 
	(@Codigo AS varchar(16), @IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdContabilizacionDocumentoTit
	FROM Accounting.ContabilizacionDocumentosTit
	WHERE Codigo=@Codigo
	
	RETURN IsNull(@Id, 0)
END


