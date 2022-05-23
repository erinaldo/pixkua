-- =============================================
-- Author: RCO
-- Create date: 26-sep-2010
-- Description:	Obtiene la información del Areas especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxAreasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.Areas WHERE IdArea=@ID)


