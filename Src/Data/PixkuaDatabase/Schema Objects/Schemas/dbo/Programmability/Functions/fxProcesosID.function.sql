-- =============================================
-- Author: Ricardo Cortés Ornelas
-- ALTER  date: 04-Mar-2005
-- Description:	Obtiene el ID del Proceso en base a su código de usuario.
-- =============================================
CREATE FUNCTION [dbo].[fxProcesosID]
	(
		@Codigo AS varchar(10),@IdSucursal as int
	)
RETURNS int
AS
BEGIN
	DECLARE @ID AS int
	
	SELECT @ID=IdProceso
	FROM Procesos
	WHERE Codigo=@Codigo

	RETURN IsNull(@ID, 0)
END


