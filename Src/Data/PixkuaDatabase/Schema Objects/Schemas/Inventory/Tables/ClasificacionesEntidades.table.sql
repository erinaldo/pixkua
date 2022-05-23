CREATE TABLE [Inventory].[ClasificacionesEntidades](
	[IdClasificacionEntidad] [int] NOT NULL,
	[Nombre] [varchar](32) NOT NULL,
 CONSTRAINT [PK_ClasificacionesEntidades] PRIMARY KEY CLUSTERED 
(
	[IdClasificacionEntidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


