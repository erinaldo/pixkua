-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Verifica la existencia de Empleados
-- =============================================
CREATE FUNCTION [RH].[fxEmpleadosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdEmpleado FROM RH.Empleados WHERE IdEmpleado=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


