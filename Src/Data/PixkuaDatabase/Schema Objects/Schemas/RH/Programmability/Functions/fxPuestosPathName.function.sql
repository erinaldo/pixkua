-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene la ruta con nombre del nodo especificado
-- =============================================

CREATE FUNCTION [RH].[fxPuestosPathName](@Id AS int)
RETURNS varchar(1024)
AS
BEGIN
	DECLARE @Result AS varchar(1024)
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int
	DECLARE @Nombre AS varchar(128)

	SELECT @NodoAux=IdPuesto, @IdPadre=IdPadre, @Nombre=Nombre
	FROM RH.Puestos
	WHERE IdPuesto=@Id

	SET @Result=@Nombre + '\'

	WHILE @IdPadre > 0
	BEGIN
		SET @NodoAux=@IdPadre

		SELECT @Nombre=Nombre, @IdPadre=IdPadre
		FROM RH.Puestos
		WHERE IdPuesto=@NodoAux

		SET @Result= @Nombre + '\' + @Result
	END

	RETURN @Result
END


