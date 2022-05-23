CREATE TABLE [Inventory].[ClasificacionesAlmacenes](
	[IdClasificacionAlmacen] [int] IDENTITY(1,1) NOT NULL,
	[IdAlmacen] [int] NOT NULL,
	[IdClasificacion] [int] NOT NULL,
 CONSTRAINT [PK_ClasificacionesAlmacenes] PRIMARY KEY CLUSTERED 
(
	[IdAlmacen] ASC,
	[IdClasificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


