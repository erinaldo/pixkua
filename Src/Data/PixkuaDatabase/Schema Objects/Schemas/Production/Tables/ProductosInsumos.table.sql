CREATE TABLE [Production].[ProductosInsumos](
	[IdProductoInsumo] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdInsumo] [int] NOT NULL,
	[IdUnidadMedida] [int] NOT NULL,
	[Cantidad] [decimal](19, 6) NOT NULL,
	[IdMetaAlmacen] [int] NOT NULL,
	[PorcMerma] [decimal](7, 6) NOT NULL,
	[Opcional] [bit] NOT NULL,
 CONSTRAINT [PK_ProductosInsumos] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC,
	[IdInsumo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


