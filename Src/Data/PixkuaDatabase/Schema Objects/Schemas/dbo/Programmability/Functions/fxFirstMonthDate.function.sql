CREATE function [dbo].[fxFirstMonthDate](@Year as int, @Month as int)
returns datetime
as
begin
	declare @FechaTemp as datetime, @MesStr as varchar(2)

	SET @MesStr=ltrim(str(@Month))
	IF len(@MesStr)=1 SET @MesStr='0' + @MesStr

	SET @FechaTemp=ltrim(str(@Year)) + @MesStr + '01'
	
	return @FechaTemp
end


