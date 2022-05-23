-- =============================================
-- Author: RCO
-- Create date: 11-ago-2011
-- Description:	Obtiene la información del Puestos especificado.
-- =============================================
CREATE FUNCTION [RH].[fxPuestosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM RH.Puestos WHERE IdPuesto=@ID)


