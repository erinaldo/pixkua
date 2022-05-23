CREATE FUNCTION [dbo].[fxLastMonthDate](@Month as int, @Year as int)
RETURNS datetime
AS
BEGIN
	DECLARE @Result as datetime
	DECLARE @LastDay as int, @DayStr as varchar(2), @MesStr as varchar(2)

	SET @LastDay=dbo.fxDaysInMonth(@Month, @Year)
	SET @DayStr=ltrim(str(@LastDay))
	IF len(@DayStr)=1 SET @DayStr='0' + @DayStr

	SET @MesStr=ltrim(str(@Month))
	IF len(@MesStr)=1 SET @MesStr='0' + @MesStr

	SET @Result=ltrim(str(@Year)) + @MesStr + @DayStr
	
	RETURN @Result
END


