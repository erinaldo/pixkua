-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Obtiene el nivel donde se encuentra el nodo especificado
-- =============================================

CREATE FUNCTION [Accounting].[fxCuentasLevel](@Id AS int)
RETURNS int
AS
BEGIN
	DECLARE @Result AS int
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int

	SET @Result=1

	SELECT @IdPadre=IdPadre, @NodoAux=IdCuenta	
	FROM Accounting.Cuentas
	WHERE IdCuenta=@Id

	WHILE @IdPadre > 0
	BEGIN
		SET @Result=@Result + 1

		SET @NodoAux=@IdPadre

		SELECT @IdPadre=IdPadre
		FROM Accounting.Cuentas
		WHERE IdCuenta=@NodoAux
	END

	RETURN @Result
END


