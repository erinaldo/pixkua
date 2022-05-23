CREATE FUNCTION [dbo].[fxLastMonthBusinessDate](@Year as int, @Month as int, @IdSucursal as int)
RETURNS datetime
AS
BEGIN
	DECLARE @MesStr as varchar(2), @FechaTemp as datetime, @Habil as bit, @Festivo as bit, @DiaSemana as int

	SET @Month= @Month+1

	SET @MesStr=ltrim(str(@Month))
	IF len(@MesStr)=1 SET @MesStr='0' + @MesStr

	SET @FechaTemp=ltrim(str(@Year)) + @MesStr + '01'
	SET @FechaTemp=dateadd(dd,-1,@FechaTemp)
		
	SELECT @Habil=Habil, @Festivo=Festivo, @DiaSemana=DiaSemana
	FROM Fechas
	WHERE Fecha=@FechaTemp AND IdSucursal=@IdSucursal

	WHILE (@Habil=0 OR @Festivo=1 OR @DiaSemana=1) AND @IdSucursal <> 4
	BEGIN
		SELECT @FechaTemp=dateadd(dd, -1, @FechaTemp)

		SELECT @Habil=Habil, @Festivo=Festivo, @DiaSemana=DiaSemana
		FROM Fechas
		WHERE Fecha=@FechaTemp AND IdSucursal=@IdSucursal
	END
	
	RETURN @FechaTemp
END


