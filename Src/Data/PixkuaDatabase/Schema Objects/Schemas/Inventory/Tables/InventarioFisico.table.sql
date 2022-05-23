CREATE TABLE [Inventory].[InventarioFisico](
	[IdInventarioFisico] [int] IDENTITY(1,1) NOT NULL,
	[IdCorte] [uniqueidentifier] NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[Teorico] [decimal](19, 4) NOT NULL,
	[Fisico] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_InventarioFisico_1] PRIMARY KEY CLUSTERED 
(
	[IdCorte] ASC,
	[IdAlmacen] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


