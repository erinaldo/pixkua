CREATE TABLE [Purchasing].[ZonasCompraAccesos](
	[IdZonaAcceso] [int] IDENTITY(1,1) NOT NULL,
	[IdZonaCompra] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Acceso] [bit] NOT NULL,
 CONSTRAINT [PK_ZonasCompraAccesos] PRIMARY KEY CLUSTERED 
(
	[IdZonaCompra] ASC,
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


