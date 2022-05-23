CREATE TABLE [Sales].[ClasificacionesClientes](
	[IdClasificacionCliente] [int] IDENTITY(1,1) NOT NULL,
	[IdClasificacion] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_ClasificacionesClientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC,
	[IdClasificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


