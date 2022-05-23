CREATE TABLE [Sales].[ServiciosZonasVenta](
	[IdServicioZonaVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdServicio] [int] NOT NULL,
	[IdZonaVenta] [int] NOT NULL,
	[IdDivisa] [int] NOT NULL,
	[Precio] [decimal](19, 4) NOT NULL,
	[DiasEntrega] [int] NOT NULL,
	[IdImpuesto1] [int] NOT NULL,
	[IdImpuesto2] [int] NOT NULL,
	[IdImpuesto3] [int] NOT NULL,
	[PorcRetencion1] [decimal](7, 6) NOT NULL,
	[PorcRetencion2] [decimal](7, 6) NOT NULL,
	[PorcRetencion3] [decimal](7, 6) NOT NULL,
 CONSTRAINT [PK_ServiciosZonasVenta] PRIMARY KEY CLUSTERED 
(
	[IdServicio] ASC,
	[IdZonaVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


