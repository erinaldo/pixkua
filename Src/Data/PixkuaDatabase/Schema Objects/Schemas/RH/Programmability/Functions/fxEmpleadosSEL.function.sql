-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene la información del Empleados especificado.
-- =============================================
CREATE FUNCTION [RH].[fxEmpleadosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM RH.Empleados WHERE IdEmpleado=@ID)


