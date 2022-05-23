-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene la ruta con código del nodo especificado
-- =============================================

CREATE FUNCTION [RH].[fxDepartamentosPathCode](@Id AS int)
RETURNS varchar(64)
AS
BEGIN
	DECLARE @Result AS varchar(64)
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result= LTrim(Str(@Id)) + '\'

	SELECT @IdPadre=IdPadre, @NodoAux=IdDepartamento
	FROM RH.Departamentos
	WHERE IdDepartamento=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result= LTrim(Str(@IdPadre)) + '\' + @Result

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM RH.Departamentos
		WHERE IdDepartamento=@NodoAux
	END

	RETURN @Result
END


