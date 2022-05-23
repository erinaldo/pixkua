-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene la ruta con nombre del nodo especificado
-- =============================================

CREATE FUNCTION [Sales].[fxEstComPathName](@Id AS int)
RETURNS varchar(1024)
AS
BEGIN
	DECLARE @Result AS varchar(1024)
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int
	DECLARE @Nombre AS varchar(128)

	SELECT @NodoAux=IdEstCom, @IdPadre=IdPadre, @Nombre=Nombre
	FROM Sales.EstCom
	WHERE IdEstCom=@Id

	SET @Result=@Nombre + '\'

	WHILE @IdPadre > 0
	BEGIN
		SET @NodoAux=@IdPadre

		SELECT @Nombre=Nombre, @IdPadre=IdPadre
		FROM Sales.EstCom
		WHERE IdEstCom=@NodoAux

		SET @Result= @Nombre + '\' + @Result
	END

	RETURN @Result
END


