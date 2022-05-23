CREATE FUNCTION [dbo].[fxPersonaExistsName](@Nombre as varchar(128), @ApellidoP as varchar(64), @ApellidoM AS varchar(64))
RETURNS Bit
AS
BEGIN
	DECLARE @Result AS bit
	IF Exists(SELECT IdPersona
			FROM Personas
			WHERE Nombre=@Nombre 
			AND ApellidoP=@ApellidoP AND ApellidoM=@ApellidoM)
		SET @Result=1
	ELSE
		SET @Result=0

	RETURN @Result
END


