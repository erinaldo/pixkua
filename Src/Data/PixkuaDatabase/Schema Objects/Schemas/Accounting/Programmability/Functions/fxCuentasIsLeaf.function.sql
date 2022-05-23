-- =============================================
-- Author: Alejandro Lopez Cadena
-- Create date: 20-sep-2007
-- Description:	Verifica si el nodo especificado se refiere a uno de nivel inferior
-- =============================================

CREATE FUNCTION [Accounting].[fxCuentasIsLeaf](@Id AS int)
RETURNS bit
AS
BEGIN
	DECLARE @Result AS bit
	DECLARE @Cant AS int

	SELECT @Cant=Count(IdCuenta)
	FROM Accounting.Cuentas
	WHERE IdPadre=@Id

	IF @Cant > 0
		SET @Result=0
	ELSE
		SET @Result=1

	RETURN @Result
END


