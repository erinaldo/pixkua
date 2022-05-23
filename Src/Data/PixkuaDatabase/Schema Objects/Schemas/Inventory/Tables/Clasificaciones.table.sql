CREATE TABLE [Inventory].[Clasificaciones](
	[IdClasificacion] [int] NOT NULL,
	[IdClasificacionGrupo] [int] NOT NULL,
	[Nombre] [varchar](64) NOT NULL,
	[Valor] [int] NOT NULL,
	[Referencia] [varchar](32) NOT NULL,
	[IdCuenta] [int] NOT NULL,
 CONSTRAINT [PK_Clasificaciones_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdClasificacionGrupo] ASC,
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


