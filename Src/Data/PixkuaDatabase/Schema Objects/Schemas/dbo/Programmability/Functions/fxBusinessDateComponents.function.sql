CREATE FUNCTION [dbo].[fxBusinessDateComponents](@IdCalendario as int, @Fecha as datetime)
RETURNS @RetTable TABLE(Fecha datetime)
AS
BEGIN
	DECLARE @Habil as bit, @Festivo as bit, @DiaSemana as int, @FechaTemp as datetime, @Dir as int
	SELECT @FechaTemp=@Fecha, @Dir=1

	INSERT INTO @RetTable(Fecha) VALUES (@FechaTemp)
	
	SELECT @FechaTemp=dateadd(dd, 1 * @Dir, @FechaTemp)
	
	SELECT @Habil=Habil, @Festivo=Festivo, @DiaSemana=DiaSemana
	FROM Fechas
	WHERE Fecha=@FechaTemp AND IdCalendario=@IdCalendario

	WHILE @Habil=1 AND (@Festivo=1 OR @DiaSemana=1)
	BEGIN
		INSERT INTO @RetTable(Fecha) VALUES (@FechaTemp)

		SELECT @FechaTemp=dateadd(dd, 1 * @Dir, @FechaTemp)

		SELECT @Habil=Habil, @Festivo=Festivo, @DiaSemana=DiaSemana
		FROM Fechas
		WHERE Fecha=@FechaTemp AND IdCalendario=@IdCalendario
	END
	
	RETURN
END


