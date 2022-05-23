CREATE TABLE [Purchasing].[CategoriasPresupuestalesServicios](
	[IdCategoriaPresupuestalServicio] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoriaPresupuestal] [int] NOT NULL,
	[IdServicio] [int] NOT NULL,
	[LastUpdate] [datetime] NOT NULL,
	[UserUpdate] [int] NOT NULL,
	[PCUpdate] [varchar](32) NOT NULL,
 CONSTRAINT [PK_CategoriasPresupuestalesServicios] PRIMARY KEY CLUSTERED 
(
	[IdCategoriaPresupuestal] ASC,
	[IdServicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


