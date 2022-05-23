CREATE TABLE [Purchasing].[PresupuestosCategorias](
	[IdPresupuestoCategoria] [int] IDENTITY(1,1) NOT NULL,
	[IdPresupuesto] [int] NOT NULL,
	[IdCategoriaPresupuestal] [int] NOT NULL,
	[MontoPresupuesto] [decimal](19, 4) NOT NULL,
	[MontoUtilizado] [decimal](19, 4) NOT NULL,
	[MontoApartado] [decimal](19, 4) NOT NULL,
 CONSTRAINT [PK_PresupuestosCategorias] PRIMARY KEY CLUSTERED 
(
	[IdPresupuesto] ASC,
	[IdCategoriaPresupuestal] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


