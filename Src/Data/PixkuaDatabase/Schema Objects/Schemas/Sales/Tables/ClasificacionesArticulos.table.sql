CREATE TABLE [Sales].[ClasificacionesArticulos](
	[IdClasificacionArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdClasificacion] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
 CONSTRAINT [PK_ClasificacionesArticulos_1] PRIMARY KEY CLUSTERED 
(
	[IdClasificacion] ASC,
	[IdArticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


