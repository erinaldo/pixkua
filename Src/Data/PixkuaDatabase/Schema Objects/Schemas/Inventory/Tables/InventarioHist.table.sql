CREATE TABLE [Inventory].[InventarioHist](
	[IdInventarioHist] [int] IDENTITY(1,1) NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdCorte] [uniqueidentifier] NOT NULL,
	[Disponible] [decimal](19, 4) NOT NULL,
	[Apartado] [decimal](19, 4) NOT NULL,
	[Transito] [decimal](19, 4) NOT NULL,
	[CostoUltimo] [decimal](19, 4) NOT NULL,
	[CostoPromedio] [decimal](19, 4) NOT NULL,
	[StockMax] [decimal](19, 4) NOT NULL,
	[StockMin] [decimal](19, 4) NOT NULL,
	[PuntoReorden] [decimal](19, 4) NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_InventarioHist_1] PRIMARY KEY CLUSTERED 
(
	[IdArticuloStock] ASC,
	[IdAlmacen] ASC,
	[IdCorte] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


