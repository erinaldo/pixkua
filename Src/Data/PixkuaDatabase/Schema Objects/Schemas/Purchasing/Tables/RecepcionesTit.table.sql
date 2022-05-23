CREATE TABLE [Purchasing].[RecepcionesTit](
	[IdRecepcionTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdOrdenTit] [char](18) NOT NULL,
	[FechaOrden] [datetime] NOT NULL,
	[HoraRecepcion] [datetime] NOT NULL,
	[IdEntrada] [char](18) NOT NULL,
	[FechaEntrada] [datetime] NULL,
	[PagoAnticipado] [bit] NOT NULL,
	[IdContrareciboTit] [char](18) NOT NULL,
	[FechaContrarecibo] [datetime] NULL,
	[IdChequeTit] [char](18) NOT NULL,
	[FechaCheque] [datetime] NULL,
	[SerieFactura] [char](10) NOT NULL,
	[FolioFactura] [int] NOT NULL,
	[UUIDFactura] [char](36) NOT NULL,
	[SerieNota] [char](10) NOT NULL,
	[FolioNota] [int] NOT NULL,
	[UUIDNota] [char](36) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestosTras] [decimal](19, 4) NOT NULL,
	[TotalImpuestosRet] [decimal](19, 4) NOT NULL,
	[TotalDescuentos] [decimal](19, 4) NOT NULL,
	[TotalFlete] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
 CONSTRAINT [PK_Compras_RecepcionesTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdRecepcionTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


