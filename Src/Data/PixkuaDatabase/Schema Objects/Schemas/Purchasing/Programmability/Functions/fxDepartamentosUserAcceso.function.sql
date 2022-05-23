CREATE FUNCTION [Purchasing].[fxDepartamentosUserAcceso](@IdDepartamento AS int,@IdUsuario as int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit

	IF EXISTS(SELECT IdDepartamento FROM Purchasing.DepartamentosAccesos WHERE IdDepartamento=@IdDepartamento AND IdUsuario=@IdUsuario)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result	
END


