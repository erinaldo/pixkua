-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 26-Mar-2006
-- Description:	Obtiene el ID de ProcesosFormas en base a su código de usuario.
-- =============================================

CREATE FUNCTION [dbo].[fxProcesosFormasID] 
	(@Codigo AS varchar(16),@IdSucursal as int)
RETURNS int
AS
BEGIN
	DECLARE @Id AS int
	
	SELECT @Id=IdProcesoForma
	FROM ProcesosFormas
	WHERE IdProcesoForma=@Codigo
	
	RETURN IsNull(@Id, 0)
END


