CREATE TABLE [Inventory].[MetaAlmacenesSucursales](
	[IdMetaAlmacenSucursal] [int] IDENTITY(1,1) NOT NULL,
	[IdMetaAlmacen] [int] NOT NULL,
	[IdSucursal] [int] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
 CONSTRAINT [PK_MetaAlmacenesSucursales] PRIMARY KEY CLUSTERED 
(
	[IdMetaAlmacen] ASC,
	[IdSucursal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


