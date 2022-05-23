-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Obtiene la información del UnidadesMedida especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxUnidadesMedidaSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.UnidadesMedida WHERE IdUnidadMedida=@ID)


