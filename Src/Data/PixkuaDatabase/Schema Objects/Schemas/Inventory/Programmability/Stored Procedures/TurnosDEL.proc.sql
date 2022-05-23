-- =============================================
-- Author: RCO
-- Create date: 11-oct-2010
-- Description:	Elimina el Turnos especificado.
-- =============================================
CREATE PROCEDURE [Inventory].[TurnosDEL]
	@ID AS int
AS
	SET NOCOUNT ON
	
	DELETE Inventory.Turnos WHERE IdTurno=@ID


