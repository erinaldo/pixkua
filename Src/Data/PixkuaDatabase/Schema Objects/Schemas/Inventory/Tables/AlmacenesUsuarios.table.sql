CREATE TABLE [Inventory].[AlmacenesUsuarios](
	[IdAlmacenUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Entrada] [bit] NOT NULL,
	[Salida] [bit] NOT NULL,
 CONSTRAINT [PK_AlmacenesUsuarios] PRIMARY KEY CLUSTERED 
(
	[IdAlmacen] ASC,
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


