CREATE FUNCTION [dbo].[fxCombineDateHour](@Fecha as datetime, @Hora as datetime)
RETURNS datetime
AS
BEGIN
	DECLARE @Result AS datetime
	DECLARE @Horas AS int, @Minutos AS int
	/*Separar hora y minutos*/
	SELECT @Horas=datepart(hour, @Hora), @Minutos=datepart(minute, @Hora)
	/*Sumar horas y minutos a campo de fecha*/
	SET @Fecha=Convert(varchar(10), @Fecha, 112)
	SET @Result=dateadd(hour, @Horas, @Fecha)
	SET @Result=dateadd(minute, @Minutos, @Result)

	RETURN @Result
END


