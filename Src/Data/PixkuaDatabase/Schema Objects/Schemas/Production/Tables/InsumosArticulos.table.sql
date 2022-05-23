CREATE TABLE [Production].[InsumosArticulos](
	[IdInsumoArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdInsumo] [int] NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[Predeterminado] [bit] NOT NULL,
 CONSTRAINT [PK_InsumosArticulos] PRIMARY KEY CLUSTERED 
(
	[IdInsumo] ASC,
	[IdArticuloStock] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


