-- =============================================
-- Author: RCO
-- Create date: 05-oct-2010
-- Description:	Obtiene la información del UnidadesMedidaTipos especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxUnidadesMedidaTiposSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.UnidadesMedidaTipos WHERE IdUnidadMedidaTipo=@ID)


