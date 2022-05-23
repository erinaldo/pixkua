-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Verifica la existencia de Departamentos
-- =============================================
CREATE FUNCTION [RH].[fxDepartamentosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdDepartamento FROM RH.Departamentos WHERE IdDepartamento=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


