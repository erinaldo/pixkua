CREATE PROCEDURE [Inventory].[TurnosAreasDEL]
	@IdArea as int,
	@IdTurno as int
AS
	SET NOCOUNT ON
		
	DELETE Inventory.TurnosAreas
	WHERE IdArea=@IdArea AND IdTurno=@IdTurno


