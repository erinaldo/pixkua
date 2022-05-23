-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene la ruta con código del nodo especificado
-- =============================================

CREATE FUNCTION [Sales].[fxEstComPathCode](@Id AS int)
RETURNS varchar(64)
AS
BEGIN
	DECLARE @Result AS varchar(64)
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result= LTrim(Str(@Id)) + '\'

	SELECT @IdPadre=IdPadre, @NodoAux=IdEstCom
	FROM Sales.EstCom
	WHERE IdEstCom=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result= LTrim(Str(@IdPadre)) + '\' + @Result

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM Sales.EstCom
		WHERE IdEstCom=@NodoAux
	END

	RETURN @Result
END


