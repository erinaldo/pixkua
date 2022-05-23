-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene el nivel donde se encuentra el nodo especificado
-- =============================================

CREATE FUNCTION [RH].[fxDepartamentosLevel](@Id AS int)
RETURNS int
AS
BEGIN
	DECLARE @Result AS int
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result=1

	SELECT @IdPadre=IdPadre, @NodoAux=IdDepartamento	
	FROM RH.Departamentos
	WHERE IdDepartamento=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result=@Result + 1

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM RH.Departamentos
		WHERE IdDepartamento=@NodoAux
	END

	RETURN @Result
END


