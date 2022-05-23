-- =============================================
-- Author: alez Lopez
-- Create date: 28-oct-2011
-- Description:	Verifica la existencia de Departamentos
-- =============================================
CREATE FUNCTION [Purchasing].[fxDepartamentosExists](@ID AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdDepartamento FROM Purchasing.Departamentos WHERE IdDepartamento=@ID)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


