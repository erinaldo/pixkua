-- =============================================
-- Author: alez Lopez
-- Create date: 08-ago-2011
-- Description:	Obtiene la información del Repartidores especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxRepartidoresSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Restaurant.Repartidores WHERE IdRepartidor=@ID)


