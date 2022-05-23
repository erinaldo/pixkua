CREATE procedure [dbo].[FechasUPD]
	@IdCalendario as int,
	@FechaIni as datetime,
	@FechaFin as datetime,
	@PrimerDiaHabil AS datetime=null
AS
	set xact_abort on
	set nocount on

	declare @idFecha datetime
	declare @Fecha as datetime
	declare @Anio int
	declare @AnioA int
	declare @Mes int
	declare @MesA int
	declare @Semana int
	declare @SemanaA int
	declare @DiaHabilAnio int
	declare @DiaHabilMes int
	declare @DiaHabilSemana int

	set @AnioA =0
	set @MesA=0
	set @SemanaA=0

	--Si no se especificó, obtener el primer dia hábil del año
	If @PrimerDiaHabil is null
	Begin
		SET @Anio=datepart(year, @FechaIni)
		SELECT @Fecha=Fecha FROM dbo.Fechas WHERE IdCalendario=@IdCalendario 
			AND Anio=@Anio AND @DiaHabilAnio=1
		IF @Fecha IS NULL
			SET @PrimerDiaHabil=LTrim(Str(@Anio)) + '0102'
		ELSE
			SET @PrimerDiaHabil=@Fecha
	End

	--Resetear campos de dias habiles
	UPDATE Fechas SET DiaHabilAnio=0, DiaHabilMes=0, 
		DiaHabilSemana=0
	WHERE Fecha between @FechaIni and @FechaFin and IdCalendario=@IdCalendario 

	--Actualizar dias habiles
	DECLARE cFechas CURSOR FOR
	select idFecha, Fecha, Anio, Mes, Semana 
	from dbo.fechas 
	where  habil=1 and Fecha between @FechaIni and @FechaFin
	AND Fecha >= @PrimerDiaHabil and IdCalendario=@IdCalendario 

	OPEN cFechas
		FETCH NEXT FROM cFechas into @idFecha, @Fecha, @Anio, @Mes, @Semana
		WHILE @@FETCH_STATUS = 0
		BEGIN
			if @Anio<>@AnioA begin
				set @AnioA=@Anio
				set @DiaHabilAnio=0
			end
			if @Mes<>@MesA begin
				set @MesA=@Mes
				set @DiaHabilMes=0
			end
			if @Semana<>@SemanaA begin
				set @SemanaA=@Semana
				set @DiaHabilSemana=0
			end
			
			set @DiaHabilAnio = @DiaHabilAnio+1		
			set @DiaHabilMes = @DiaHabilMes+1
			set @DiaHabilSemana = @DiaHabilSemana+1

			UPDATE dbo.Fechas SET DiaHabilAnio=@DiaHabilAnio, DiaHabilMes=@DiaHabilMes, 
				DiaHabilSemana=@DiaHabilSemana
			WHERE CURRENT OF cFechas

			FETCH NEXT FROM cFechas into @idFecha, @Fecha, @Anio, @Mes, @Semana
		END
	CLOSE cFechas
	DEALLOCATE cFechas
	--Actualizar campo de semana hábil

	declare @DiffSem as int
	select @DiffSem=datediff(wk, @FechaIni, @PrimerDiaHabil)

	UPDATE Fechas SET SemanaHabil = Semana - @DiffSem
	WHERE Fecha Between @FechaIni AND @FechaFin
	AND Fecha > @PrimerDiaHabil and IdCalendario=@IdCalendario


