-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Obtiene la información del CentrosConsumo especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxCentrosConsumoSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Restaurant.CentrosConsumo WHERE IdCentroConsumo=@ID)


