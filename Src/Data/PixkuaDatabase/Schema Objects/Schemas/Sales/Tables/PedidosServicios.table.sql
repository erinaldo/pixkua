CREATE TABLE [Sales].[PedidosServicios](
	[IdPedidoServicio] [int] IDENTITY(1,1) NOT NULL,
	[IdPedidoTit] [char](18) NOT NULL,
	[FechaPedido] [datetime] NOT NULL,
	[IdVentaTit] [char](18) NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
 CONSTRAINT [PK_PedidosServicios] PRIMARY KEY CLUSTERED 
(
	[FechaPedido] ASC,
	[IdPedidoTit] ASC,
	[FechaVenta] ASC,
	[IdVentaTit] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


