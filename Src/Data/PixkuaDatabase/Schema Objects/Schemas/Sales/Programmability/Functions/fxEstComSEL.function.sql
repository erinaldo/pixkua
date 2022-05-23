-- =============================================
-- Author: RCO
-- Create date: 08-sep-2010
-- Description:	Obtiene la información del EstCom especificado.
-- =============================================
CREATE FUNCTION [Sales].[fxEstComSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Sales.EstCom WHERE IdEstCom=@ID)


