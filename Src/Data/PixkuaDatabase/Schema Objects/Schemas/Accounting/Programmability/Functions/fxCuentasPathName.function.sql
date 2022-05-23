-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Obtiene la ruta con nombre del nodo especificado
-- =============================================

CREATE FUNCTION [Accounting].[fxCuentasPathName](@Id AS int)
RETURNS varchar(1024)
AS
BEGIN
	DECLARE @Result AS varchar(1024)
	DECLARE @NodoAux AS int
	DECLARE @IdPadre AS int
	DECLARE @Nombre AS varchar(128)

	SELECT @NodoAux=IdCuenta, @IdPadre=IdPadre, @Nombre=Nombre
	FROM Accounting.Cuentas
	WHERE IdCuenta=@Id

	SET @Result=@Nombre + '\'

	WHILE @IdPadre > 0
	BEGIN
		SET @NodoAux=@IdPadre

		SELECT @Nombre=Nombre, @IdPadre=IdPadre
		FROM Accounting.Cuentas
		WHERE IdCuenta=@NodoAux

		SET @Result= @Nombre + '\' + @Result
	END

	RETURN @Result
END


