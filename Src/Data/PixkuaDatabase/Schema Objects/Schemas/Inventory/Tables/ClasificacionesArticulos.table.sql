CREATE TABLE [Inventory].[ClasificacionesArticulos](
	[IdClasificacionesArticulos] [int] IDENTITY(1,1) NOT NULL,
	[IdArticuloStock] [int] NOT NULL,
	[IdClasificacion] [int] NOT NULL,
 CONSTRAINT [PK_ClasificacionesArticulos] PRIMARY KEY CLUSTERED 
(
	[IdArticuloStock] ASC,
	[IdClasificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


