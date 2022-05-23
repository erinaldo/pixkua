CREATE TABLE [Sales].[PedidosTit](
	[IdPedidoTit] [char](18) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Hora] [datetime] NOT NULL,
	[IdPedidoTipo] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdVendedor] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[FechaEmbarque] [datetime] NULL,
	[FechaEntrega] [datetime] NULL,
	[IdListaPrecio] [int] NOT NULL,
	[OrdenCompra] [varchar](32) NOT NULL,
	[IdReferencia] [char](18) NOT NULL,
	[Observaciones] [varchar](256) NOT NULL,
	[TotalCantidad] [decimal](19, 4) NOT NULL,
	[TotalSaldo] [decimal](19, 4) NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[TipoCambio] [decimal](19, 4) NOT NULL,
	[SubTotal] [decimal](19, 4) NOT NULL,
	[TotalImpuestosTras] [decimal](19, 4) NOT NULL,
	[TotalImpuestosRet] [decimal](19, 4) NOT NULL,
	[TotalDescuentos] [decimal](19, 4) NOT NULL,
	[TotalFlete] [decimal](19, 4) NOT NULL,
	[TotalComision] [decimal](19, 4) NOT NULL,
	[Total] [decimal](19, 4) NOT NULL,
	[TotalIVA] [decimal](19, 4) NOT NULL,
	[TotalIEPS] [decimal](19, 4) NOT NULL,
	[IdStatus] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Ventas_PedidosTit] PRIMARY KEY CLUSTERED 
(
	[Fecha] ASC,
	[IdPedidoTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


