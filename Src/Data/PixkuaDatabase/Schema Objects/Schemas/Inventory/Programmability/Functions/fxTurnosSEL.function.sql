-- =============================================
-- Author: RCO
-- Create date: 11-oct-2010
-- Description:	Obtiene la información del Turnos especificado.
-- =============================================
CREATE FUNCTION [Inventory].[fxTurnosSEL](@ID AS int, @IdUsuario AS int)
RETURNS TABLE
AS
	RETURN
	(SELECT * FROM Inventory.Turnos WHERE IdTurno=@ID)


