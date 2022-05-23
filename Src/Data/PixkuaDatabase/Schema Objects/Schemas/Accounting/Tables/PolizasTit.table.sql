CREATE TABLE [Accounting].[PolizasTit](
	[IdPolizaTit] [varchar](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdEjercicioFiscalTit] [varchar](18) NOT NULL,
	[IdPolizaPerfil] [int] NOT NULL,
	[Folio] [int] NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_PolizasTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdPolizaTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


