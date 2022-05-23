CREATE PROCEDURE [Inventory].[TurnosAreasUPD]
	@IdArea as int,
	@IdTurno as int,
	@Secuencia as int
AS
	SET NOCOUNT ON
	
	IF NOT EXISTS(SELECT IdArea FROM Inventory.TurnosAreas WHERE IdArea=@IdArea AND IdTurno=@IdTurno)	
		INSERT INTO Inventory.TurnosAreas (IdArea, IdTurno, Secuencia)
		VALUES (@IdArea, @IdTurno, @Secuencia)


