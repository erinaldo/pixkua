-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Obtiene la información del Mesas especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxMesasSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Restaurant.Mesas WHERE IdMesa=@ID)


