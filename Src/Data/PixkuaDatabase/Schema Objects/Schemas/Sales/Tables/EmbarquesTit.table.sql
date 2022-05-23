CREATE TABLE [Sales].[EmbarquesTit](
	[IdPedidoTit] [char](18) NOT NULL,
	[FechaPedido] [datetime] NOT NULL,
	[FolioEmbarque] [int] NOT NULL,
	[FechaEmbarque] [datetime] NOT NULL,
	[HoraEmbarque] [datetime] NOT NULL,
	[FechaEntrega] [datetime] NOT NULL,
	[FechaRecepcion] [datetime] NULL,
	[FechaCobro] [datetime] NULL,
	[IdContenedor] [int] NOT NULL,
	[IdVentaTit] [char](18) NOT NULL,
	[FechaVenta] [datetime] NULL,
	[IdSerieFactura] [int] NOT NULL,
	[SerieFactura] [char](10) NOT NULL,
	[FolioFactura] [int] NOT NULL,
	[IdDevolucionTit] [char](18) NOT NULL,
	[FechaDevolucion] [datetime] NULL,
	[IdSerieNota] [int] NOT NULL,
	[SerieNota] [char](10) NOT NULL,
	[FolioNota] [int] NOT NULL,
	[CalleEntrega] [varchar](128) NOT NULL,
	[Cruce1Entrega] [varchar](128) NOT NULL,
	[Cruce2Entrega] [varchar](128) NOT NULL,
	[NumExtEntrega] [varchar](16) NOT NULL,
	[NumIntEntrega] [varchar](16) NOT NULL,
	[ColoniaEntrega] [varchar](128) NOT NULL,
	[CPEntrega] [char](5) NOT NULL,
	[IdPoblacionEntrega] [int] NOT NULL,
	[TotalCantidad] [decimal](19, 4) NOT NULL,
	[TotalRecibido] [decimal](19, 4) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_EmbarquesTit] PRIMARY KEY CLUSTERED 
(
	[FechaPedido] ASC,
	[IdPedidoTit] ASC,
	[FolioEmbarque] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


