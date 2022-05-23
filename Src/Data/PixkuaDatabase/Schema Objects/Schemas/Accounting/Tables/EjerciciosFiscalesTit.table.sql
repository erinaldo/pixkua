CREATE TABLE [Accounting].[EjerciciosFiscalesTit](
	[IdEjercicioFiscalTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdEmpresa] [int] NOT NULL,
	[FechaIni] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_EjerciciosFiscalesTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdEjercicioFiscalTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


