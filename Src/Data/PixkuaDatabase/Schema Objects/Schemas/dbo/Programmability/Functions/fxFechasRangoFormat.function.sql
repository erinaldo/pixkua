create function [dbo].[fxFechasRangoFormat] (@FechaIni as datetime,@FechaFin as datetime)
returns varchar (60)
as
begin

	declare @sRet as varchar(60)

	if year(@FechaIni) = year(@FechaFin)
	begin
		if month(@FechaIni) = month(@FechaFin)
		begin
			set @sRet = 'del ' + cast(day(@FechaIni) as varchar) + ' al ' + cast(day(@FechaFin) as varchar) + ' de ' + dbo.fxMonthNumberToName (month(@FechaFin)) + ' ' + cast(year(@FechaFin) as varchar)
		end
		else
		begin
			set @sRet = 'del ' + cast(day(@FechaIni) as varchar) + ' de ' + dbo.fxMonthNumberToName (month(@FechaIni)) + ' al ' + cast(day(@FechaFin) as varchar) + ' de ' + dbo.fxMonthNumberToName (month(@FechaFin)) + ' ' + cast(year(@FechaFin) as varchar)
		end
	end
	else
	begin
		set @sRet = 'del ' + cast(day(@FechaIni) as varchar) + ' de ' + dbo.fxMonthNumberToName (month(@FechaIni)) + ' ' +  cast(year(@FechaIni) as varchar) + ' al ' + cast(day(@FechaFin) as varchar) + ' de ' + dbo.fxMonthNumberToName (month(@FechaFin)) + ' ' + cast(year(@FechaFin) as varchar)
	end

	Return @sRet

end


