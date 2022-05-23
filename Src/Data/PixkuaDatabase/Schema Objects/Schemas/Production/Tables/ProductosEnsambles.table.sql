CREATE TABLE [Production].[ProductosEnsambles](
	[IdProductoEnsamble] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[IdSubProducto] [int] NOT NULL,
	[IdUnidadMedida] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[OrdenSeparada] [bit] NOT NULL,
 CONSTRAINT [PK_ProductosEnsambles] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC,
	[IdSubProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


