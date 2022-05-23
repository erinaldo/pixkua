CREATE FUNCTION [dbo].[fxFirstMonthBusinessDate](@IdCalendario as int, @Year as int, @Month as int)
RETURNS datetime
AS
BEGIN
	DECLARE @MesStr as varchar(2), @FechaTemp as datetime, @Habil as bit, @Festivo as bit, @DiaSemana as int

	SET @MesStr=ltrim(str(@Month))
	IF len(@MesStr)=1 SET @MesStr='0' + @MesStr

	SET @FechaTemp=ltrim(str(@Year)) + @MesStr + '01'
		
	SELECT @Habil=Habil, @Festivo=Festivo, @DiaSemana=DiaSemana
	FROM Fechas
	WHERE Fecha=@FechaTemp AND IdCalendario=@IdCalendario

	WHILE (@Habil=0 OR @Festivo=1 OR @DiaSemana=1) AND @IdCalendario <> 4
	BEGIN
		SELECT @FechaTemp=dateadd(dd, 1, @FechaTemp)

		SELECT @Habil=Habil, @Festivo=Festivo, @DiaSemana=DiaSemana
		FROM Fechas
		WHERE Fecha=@FechaTemp AND IdCalendario=@IdCalendario
	END
	
	RETURN @FechaTemp
END


