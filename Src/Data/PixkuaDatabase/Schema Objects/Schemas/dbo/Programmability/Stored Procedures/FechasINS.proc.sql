CREATE procedure [dbo].[FechasINS]
	@IdCalendario as int,
	@FechaIni as datetime,
	@FechaFin as datetime,
	@SabadoLaborable as bit,
	@DomingoLaborable as bit
AS
	set xact_abort on -->salir al primer error
	set nocount on

	SET DATEFORMAT DMY
	SET DATEFIRST 7

	-->declaracion de variables
	DECLARE @Fecha 		datetime
	DECLARE	@Habil		bit
	DECLARE @Festivo	bit
	DECLARE @Descr		varchar(64)	
	DECLARE	@Anio 		smallint
	DECLARE	@Trimestre	smallint
	DECLARE	@Mes		smallint
	DECLARE	@Semana		smallint
	DECLARE	@DiaAnio	smallint
	DECLARE	@DiaMes	        smallint
	DECLARE	@DiaSemana	smallint
	DECLARE	@DiaHabilAnio	smallint
	DECLARE	@DiaHabilMes	smallint
	DECLARE	@DiaHabilSemana	smallint
	DECLARE	@TrimestreLargo	varchar(32)
	DECLARE	@TrimestreCorto	varchar(8)
	DECLARE	@MesLargo	varchar(32)
	DECLARE	@MesCorto	varchar(8)
	DECLARE	@DiaLargo	varchar(32)
	DECLARE	@DiaCorto	varchar(8)
	DECLARE	@Estacion	varchar(32)
	DECLARE	@Observaciones	varchar(128)

	SET @Fecha = @FechaIni
	WHILE @Fecha<=@FechaFin
	BEGIN
		-->obtener valores numéricos
		set @Habil = 1
		set @Festivo=0
		set @Descr=''
		set @Anio = datepart(year,@Fecha)
		set @Mes = datepart(month,@Fecha)
		set @DiaAnio = datepart(dy,@Fecha)
		set @DiaMes = datepart(day,@Fecha)
		set @DiaSemana = datepart(dw,@Fecha)
		set @Semana = datepart(wk,@Fecha)
		set @Trimestre = datepart(qq,@Fecha)

		-->trimestres
		if @Trimestre = 1  begin
			set @TrimestreLargo='Pimer Trimestre'
			set @TrimestreCorto='T1'
		end

		if @Trimestre = 2  begin
			set @TrimestreLargo='Segundo Trimestre'
			set @TrimestreCorto='T2'
		end

		if @Trimestre = 3  begin
			set @TrimestreLargo='Tercer Trimestre'
			set @TrimestreCorto='T3'
		end

		if @Trimestre = 4  begin
			set @TrimestreLargo='Cuarto Trimestre'
			set @TrimestreCorto='T4'
		end

		-->meses
		if @Mes=1 begin
			set @MesLargo='Enero'
			set @MesCorto='Ene'
		end

		if @Mes=2 begin
			set @MesLargo='Febrero'
			set @MesCorto='Feb'
		end

		if @Mes=3 begin
			set @MesLargo='Marzo'
			set @MesCorto='Mzo'
		end

		if @Mes=4 begin
			set @MesLargo='Abril'
			set @MesCorto='Abr'
		end

		if @Mes=5 begin
			set @MesLargo='Mayo'
			set @MesCorto='May'
		end

		if @Mes=6 begin
			set @MesLargo='Junio'
			set @MesCorto='Jun'
		end

		if @Mes=7 begin
			set @MesLargo='Julio'
			set @MesCorto='Jul'
		end

		if @Mes=8 begin
			set @MesLargo='Agosto'
			set @MesCorto='Ago'
		end

		if @Mes=9 begin
			set @MesLargo='Septiembre'
			set @MesCorto='Sep'
		end

		if @Mes=10 begin
			set @MesLargo='Octubre'
			set @MesCorto='Oct'
		end

		if @Mes=11 begin
			set @MesLargo='Noviembre'
			set @MesCorto='Nov'
		end

		if @Mes=12 begin
			set @MesLargo='Diciembre'
			set @MesCorto='Dic'
		end

		-->semanas
		if @DiaSemana=2 begin
			set @DiaLargo='Lunes'
			set @DiaCorto='Lun'
		end

		if @DiaSemana=3 begin
			set @DiaLargo='Martes'
			set @DiaCorto='Mar'
		end

		if @DiaSemana=4 begin
			set @DiaLargo='Miercoles'
			set @DiaCorto='Mie'
		end

		if @DiaSemana=5 begin
			set @DiaLargo='Jueves'
			set @DiaCorto='Jue'
		end

		if @DiaSemana=6 begin
			set @DiaLargo='Viernes'
			set @DiaCorto='Vie'
		end

		if @DiaSemana=7 begin
			set @DiaLargo='Sabado'
			set @DiaCorto='Sab'
			if @SabadoLaborable=0 set @Habil = 0
		end

		if @DiaSemana=1 begin
			set @DiaLargo='Domingo'
			set @DiaCorto='Dom'
			if @DomingoLaborable=0 set @Habil = 0
		end

		-->estaciones
		if @Fecha between rtrim(ltrim(str(@Anio-1)))+'1221' and rtrim(ltrim(str(@Anio)))+'0320' set @Estacion='Invierno'
		if @Fecha between rtrim(ltrim(str(@Anio)))+'0321' and rtrim(ltrim(str(@Anio)))+'0620' set @Estacion='Primavera'
		if @Fecha between rtrim(ltrim(str(@Anio)))+'0621' and rtrim(ltrim(str(@Anio)))+'0920' set @Estacion='Verano'
		if @Fecha between rtrim(ltrim(str(@Anio)))+'0921' and rtrim(ltrim(str(@Anio)))+'1220' set @Estacion='Otoño'
		if @Fecha between rtrim(ltrim(str(@Anio)))+'1221' and rtrim(ltrim(str(@Anio+1)))+'0320' set @Estacion='Invierno'

		-->dias festivos
		if @Mes =  1 and @DiaMes =  1 -- 1 ENERO(AÑO NUEVO)
		begin
			set @Habil=0 
			set @Festivo=1
			set @Descr='Año Nuevo'
		end
		if @Mes = 12 and @DiaMes = 25 --25 DICIEMBRE(NAVIDAD)
		begin
			set @Habil = 0  
			set @Festivo=1
			set @Descr='Navidad'
		end
		-->insertar registro en la tabla de fechas
		insert into fechas (IdCalendario, Fecha, Habil, Festivo, Descr, Anio, Trimestre, Mes, Semana, 
			DiaAnio, DiaMes, DiaSemana, TrimestreLargo, TrimestreCorto, MesLargo, MesCorto, DiaLargo, 
			DiaCorto, Estacion)
		values (@IdCalendario, @Fecha, @Habil, @Festivo, @Descr, @Anio, @Trimestre, @Mes, @Semana,
			@DiaAnio, @DiaMes, @DiaSemana, @TrimestreLargo, @TrimestreCorto, @MesLargo, @MesCorto, @DiaLargo, 
			@DiaCorto, @Estacion)

		--pasar al dia siguiente
		set @Fecha = dateadd(day,1,@Fecha)
	END


