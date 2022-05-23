CREATE TABLE [Purchasing].[CategoriasPresupuestalesArticulos](
	[IdCategoriaPresupuestalArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoriaPresupuestal] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_CategoriasPresupuestalesArticulos] PRIMARY KEY CLUSTERED 
(
	[IdCategoriaPresupuestal] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


