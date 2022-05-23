-- =============================================
-- Author: alez lopez
-- Create date: 04-mar-2011
-- Description:	Obtiene la información del Insumos especificado.
-- =============================================
CREATE FUNCTION [Production].[fxInsumosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Production.Insumos WHERE IdInsumo=@ID)


