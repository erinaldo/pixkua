-- =============================================
-- Author: alez lopez
-- Create date: 19-ene-2011
-- Description:	Obtiene la información del CentrosProduccion especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxCentrosProduccionSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Restaurant.CentrosProduccion WHERE IdCentroProduccion=@ID)


