CREATE TABLE [dbo].[Fechas](
	[IdFecha] [int] IDENTITY(1,1) NOT NULL,
	[IdCalendario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Habil] [bit] NOT NULL,
	[Festivo] [bit] NOT NULL,
	[Anio] [int] NOT NULL,
	[Trimestre] [int] NOT NULL,
	[Mes] [int] NOT NULL,
	[Semana] [int] NOT NULL,
	[SemanaHabil] [int] NOT NULL,
	[DiaAnio] [int] NOT NULL,
	[DiaMes] [int] NOT NULL,
	[DiaSemana] [int] NOT NULL,
	[DiaHabilAnio] [int] NOT NULL,
	[DiaHabilMes] [int] NOT NULL,
	[DiaHabilSemana] [int] NOT NULL,
	[TrimestreLargo] [varchar](32) NOT NULL,
	[TrimestreCorto] [varchar](16) NOT NULL,
	[MesLargo] [varchar](32) NOT NULL,
	[MesCorto] [varchar](8) NOT NULL,
	[DiaLargo] [varchar](32) NOT NULL,
	[DiaCorto] [varchar](8) NOT NULL,
	[Estacion] [varchar](32) NOT NULL,
	[Descr] [varchar](128) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_Fechas] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdCalendario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


