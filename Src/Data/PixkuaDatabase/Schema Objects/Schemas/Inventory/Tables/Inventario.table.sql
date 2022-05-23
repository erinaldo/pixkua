CREATE TABLE [Inventory].[Inventario](
	[IdInventario] [int] IDENTITY(1,1) NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[Disponible] [decimal](19, 6) NOT NULL,
	[Apartado] [decimal](19, 6) NOT NULL,
	[Transito] [decimal](19, 6) NOT NULL,
	[CostoUltimo] [decimal](19, 4) NOT NULL,
	[CostoPromedio] [decimal](19, 4) NOT NULL,
	[StockMax] [decimal](19, 4) NOT NULL,
	[StockMin] [decimal](19, 4) NOT NULL,
	[PuntoReorden] [decimal](19, 4) NOT NULL,
	[Ubicacion] [varchar](32) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdArticuloStock] ASC,
	[IdAlmacen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


