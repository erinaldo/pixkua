CREATE FUNCTION [dbo].[fxDaysInMonth](@Month as int, @year as int)
RETURNS int
AS
BEGIN
	DECLARE @Result as int
	
	DECLARE @FechaTemp as datetime, @MesStr as varchar(2)
	-->Formatear mes
	IF @Month < 12
		SET @Month=@Month + 1
	ELSE
		SET @Month=1

	SET @MesStr=ltrim(str(@Month))
	IF len(@MesStr)=1 SET @MesStr='0' + @MesStr
	-->Crear fecha del primer dia del mes siguiente
	SET @FechaTemp=ltrim(str(@year)) + @MesStr + '01'
	-->Restar un día
	SET @Result=datepart(dd, dateadd(dd, -1, @FechaTemp))

	RETURN @Result
END


