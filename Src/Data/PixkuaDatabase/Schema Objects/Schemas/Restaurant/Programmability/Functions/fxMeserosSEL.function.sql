-- =============================================
-- Author: alez lopez
-- Create date: 27-jun-2011
-- Description:	Obtiene la información del Meseros especificado.
-- =============================================
CREATE FUNCTION [Restaurant].[fxMeserosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Restaurant.Meseros WHERE IdMesero=@ID)


