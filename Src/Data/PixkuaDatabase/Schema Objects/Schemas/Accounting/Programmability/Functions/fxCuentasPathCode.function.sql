-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Obtiene la ruta con código del nodo especificado
-- =============================================

CREATE FUNCTION [Accounting].[fxCuentasPathCode](@Id AS int)
RETURNS varchar(64)
AS
BEGIN
	DECLARE @Result AS varchar(64)
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result= LTrim(Str(@Id)) + '\'

	SELECT @IdPadre=IdPadre, @NodoAux=IdCuenta
	FROM Accounting.Cuentas
	WHERE IdCuenta=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result= LTrim(Str(@IdPadre)) + '\' + @Result

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM Accounting.Cuentas
		WHERE IdCuenta=@NodoAux
	END

	RETURN @Result
END


