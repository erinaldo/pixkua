-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene el nivel donde se encuentra el nodo especificado
-- =============================================

CREATE FUNCTION [Sales].[fxEstComLevel](@Id AS int)
RETURNS int
AS
BEGIN
	DECLARE @Result AS int
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result=1

	SELECT @IdPadre=IdPadre, @NodoAux=IdEstCom	
	FROM Sales.EstCom
	WHERE IdEstCom=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result=@Result + 1

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM Sales.EstCom
		WHERE IdEstCom=@NodoAux
	END

	RETURN @Result
END


