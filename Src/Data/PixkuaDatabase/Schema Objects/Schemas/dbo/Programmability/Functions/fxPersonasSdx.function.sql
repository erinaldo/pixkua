CREATE FUNCTION [dbo].[fxPersonasSdx](@Nombre AS varchar(128), @ApellidoP AS varchar(64), @ApellidoM AS varchar(64))
RETURNS TABLE
AS 
RETURN (
		SELECT IdPersona, Codigo, Nombre, ApellidoP, ApellidoM, 
			Calle + ' #' + NumExt AS Domicilio, TelCasa
		FROM Personas
		WHERE dbo.fxCompareNameSdx(@Nombre, Nombre)=1
			AND dbo.fxCompareNameSdx(@ApellidoP, ApellidoP)=1
			AND dbo.fxCompareNameSdx(@ApellidoM, ApellidoM)=1
		)


