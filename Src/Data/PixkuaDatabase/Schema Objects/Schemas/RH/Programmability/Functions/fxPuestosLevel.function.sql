-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene el nivel donde se encuentra el nodo especificado
-- =============================================

CREATE FUNCTION [RH].[fxPuestosLevel](@Id AS int)
RETURNS int
AS
BEGIN
	DECLARE @Result AS int
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result=1

	SELECT @IdPadre=IdPadre, @NodoAux=IdPuesto	
	FROM RH.Puestos
	WHERE IdPuesto=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result=@Result + 1

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM RH.Puestos
		WHERE IdPuesto=@NodoAux
	END

	RETURN @Result
END


